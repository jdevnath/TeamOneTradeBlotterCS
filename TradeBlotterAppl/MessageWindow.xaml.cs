﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Windows.Navigation;

using System.Runtime.Serialization.Json;

using System.Collections;
using System.ComponentModel;
using System.Collections.Specialized;

namespace TradeBlotterAppl
{
    /// <summary>
    /// Interaction logic for UserSpecificWindow.xaml
    /// </summary>
    public partial class MessageWindow : Window
    {
        public string messageSubject;
        public string messageContent;
        public string messageSender;
        private readonly PagingCollectionViewMessage _cview;
        public string username;
        public MessageWindow(MessageData[] other,string name)
        {

            InitializeComponent();
            this.username = name;
            this._cview = new PagingCollectionViewMessage(
                other,
                15
            );
            this.DataContext = this._cview;
        }

        private void OnNextClicked(object sender, RoutedEventArgs e)
        {
            this._cview.MoveToNextPage();
        }

        private void OnPreviousClicked(object sender, RoutedEventArgs e)
        {
            this._cview.MoveToPreviousPage();
        }


        private void changeTheSelection(object sender, SelectionChangedEventArgs e)
        {
            var item = sender as TabControl;
            var selected = item.SelectedItem as TabItem;
            this.Title = selected.Header.ToString();
        }

        private void sendingMessage(object sender, RoutedEventArgs e)
        {
            messageContent = txtMessageBox.Text;
            messageSubject = txtSubjectType.Text;
            var client = new WebClient();
            using (client)
            {
                var values = new NameValueCollection();
                values["messageBody"] = messageContent;
                values["subjectName"] = messageSubject;
                values["userName"] = this.username;
                var res = client.UploadValues("http://10.87.226.147:8080/TeamOneTradeBlotterFinalWeb/rest/messages/create", values);
                var str = Encoding.Default.GetString(res);

            }
        }
    }

    // ===================

    public class PagingCollectionViewMessage : CollectionView
    {
        private readonly IList _innerList;
        private readonly int _itemsPerPage;

        private int _currentPage = 1;

        public PagingCollectionViewMessage(IList innerList, int itemsPerPage)
            : base(innerList)
        {
            this._innerList = innerList;
            this._itemsPerPage = itemsPerPage;
        }

        public override int Count
        {
            get
            {
                if (this._innerList.Count == 0) return 0;
                if (this._currentPage < this.PageCount) // page 1..n-1
                {
                    return this._itemsPerPage;
                }
                else // page n
                {
                    var itemsLeft = this._innerList.Count % this._itemsPerPage;
                    if (0 == itemsLeft)
                    {
                        return this._itemsPerPage; // exactly itemsPerPage left
                    }
                    else
                    {
                        // return the remaining items
                        return itemsLeft;
                    }
                }
            }
        }

        public int CurrentPage
        {
            get { return this._currentPage; }
            set
            {
                this._currentPage = value;
                this.OnPropertyChanged(new PropertyChangedEventArgs("CurrentPage"));
            }
        }

        public int ItemsPerPage { get { return this._itemsPerPage; } }

        public int PageCount
        {
            get
            {
                return (this._innerList.Count + this._itemsPerPage - 1)
                    / this._itemsPerPage;
            }
        }

        private int EndIndex
        {
            get
            {
                var end = this._currentPage * this._itemsPerPage - 1;
                return (end > this._innerList.Count) ? this._innerList.Count : end;
            }
        }

        private int StartIndex
        {
            get { return (this._currentPage - 1) * this._itemsPerPage; }
        }

        public override object GetItemAt(int index)
        {
            var offset = index % (this._itemsPerPage);
            return this._innerList[this.StartIndex + offset];
        }

        public void MoveToNextPage()
        {
            if (this._currentPage < this.PageCount)
            {
                this.CurrentPage += 1;
            }
            this.Refresh();
        }

        public void MoveToPreviousPage()
        {
            if (this._currentPage > 1)
            {
                this.CurrentPage -= 1;
            }
            this.Refresh();
        }
    }

}
