   M S B A M L   `   `   `  ����K  GTradeBlotterAppl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TradeBlotterApplTradeBlotterAppl  5   	   )    #TradeBlotterAppl.UserSpecificWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TradeBlotterAppl     5   	     � Title$  UserSpecificWindow��5   	   $	��600��6$   $
��1200��5	   	    � Left$ 80��5
   	   
 � Top$	 100��5   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      ��  �� Orientation$ 
Horizontal=�6   $��1��62   $��448,485,-82,43q�6?   .+�5      �� $��0��6   $��5q�6%   ��5      �� 5       �� Path$ CurrentPage�6"    �� StringFormat$ Current Page: {0}��5   [   5      5      �� 5      -   5        $
��Next��5      $��2q�6>   �� 5      -   5        $��Previous��5      $��2q�6F   5      �� 5      $��104,52,-196,396q�6   $��1��62   .+�5      �� -   5         ��Name$ loginImage_png��5      $��52��60   $��loginImage.png��6<   $
��Fill=�6T   $��73��6c   $��560,0,559,0q�6n   5       &   System.Windows.Controls.DataGrid  5!      -   5        $��	userTrade��5!      $��1��6@   $��44,130,238,90q�6M   ��6(   ��    Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn	   Header$	 tradeId��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6:   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	tradeId+  5$      $	 	buyerFirm��6)   $
 * 6<    6F   �� *	buyerFirm+  5%      $	 currency��6)   $
 * 6;    6E   �� *
currency+  5&      $	 executionTime��6)   $
 * 6@    6J   �� *executionTime+  5(      $	 price��6)   $
 * 68    6B   �� *price+  5)      $	 productName��6)   $
 * 6>    6H   �� *productName+  5*      $	 productType��6)   $
 * 6>    6H   �� *productType+  5+      $	 quantity��6)   $
 * 6;    6E   �� *
quantity+  5,      $	 
sellerFirm��6)   $
 * 6=    6G   �� *
sellerFirm+  5.      $	 status��6)   $
 * 69    6C   �� *status+  5/      $	 
submitTime��6)   $
 * 6=    6G   �� *
submitTime+  50      $	 traderId��6)   $
 * 6;    6E   �� *traders_traderId+52      �� 54      -   5         ��Name$ lstUserName��54      $
��Left=�6+   $��35(�6F   
�������$��48��6h   $��
815,52,0,0q�6t   $��1��6�   $	��Top=�6�   $	��180��6�   55      56      5<      5=      