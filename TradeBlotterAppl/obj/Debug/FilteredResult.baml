   M S B A M L   `   `   `  ����K  GTradeBlotterAppl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TradeBlotterApplTradeBlotterAppl  5   	   %    TradeBlotterAppl.FilteredResult   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TradeBlotterAppl     5   	     � Title$  FilteredResult��5   	   $	��600��5	   	   $
��1200��5
   	    � Left$ 80��5   	   
 � Top$	 100��5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��1��6.   $��243,391,123,36q�6;    J� RenderTransformOrigin$ 0.5,0.5&�6S   .+�5      �� $��0��6   $��5q�6!   ��5      �� 5       �� Path$ CurrentPage�6    �� StringFormat$ Current Page: {0}��5   W   5      5      �� 5      -   5        $
��Next��5      $��2q�6:   �� 5      -   5        $��Previous��5      $��2q�6B   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataFilterredTrade��5      $��1��6E   $��10,64,10,84q�6R   ��6-   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 tradeId��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 66   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *	tradeId+  5       $	 	buyerFirm��6%   $
 * 68    6B   �� *	buyerFirm+  5!      $	 currency��6%   $
 * 67    6A   �� *
currency+  5"      $	 executionTime��6%   $
 * 6<    6F   �� *executionTime+  5$      $	 price��6%   $
 * 64    6>   �� *price+  5%      $	 productName��6%   $
 * 6:    6D   �� *productName+  5&      $	 productType��6%   $
 * 6:    6D   �� *productType+  5'      $	 quantity��6%   $
 * 67    6A   �� *
quantity+  5(      $	 
sellerFirm��6%   $
 * 69    6C   �� *
sellerFirm+  5*      $	 status��6%   $
 * 65    6?   �� *status+  5+      $	 
submitTime��6%   $
 * 69    6C   �� *
submitTime+  5,      $	 traderId��6%   $
 * 67    6A   �� *traders_traderId+5.      50      51      