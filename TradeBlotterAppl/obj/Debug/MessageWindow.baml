   M S B A M L   `   `   `  ����K  GTradeBlotterAppl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TradeBlotterApplTradeBlotterAppl  5   	   $    TradeBlotterAppl.MessageWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TradeBlotterAppl     5   	     � Title$  MessageWindow��5   	   $	��600��6   $
��1200��5	   	    � Left$ 80��5
   	   
 � Top$	 100��5   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      ��  �� Orientation$ 
Horizontal=�6   $��1��62   $��448,485,-82,43q�6?   .+�5      �� $��0��6   $��5q�6%   ��5      �� 5       �� Path$ CurrentPage�6"    �� StringFormat$ Current Page: {0}��5   [   5      5      �� 5      -   5        $
��Next��5      $��2q�6>   �� 5      -   5        $��Previous��5      $��2q�6F   5      &   System.Windows.Controls.DataGrid  5      -   5        $��messages��5      $��1��6?   $��10,85,269,90q�6L   ��6'   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ 	messageId��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6<   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6F   �� *	messageId+  5!      $ 	messageId��6)   $	 * 6<   
 6F   �� *traders_traderId+  5"      $ 	messageId��6)   $	 * 6<   
 6F   �� *subjects_subjectId+  5#      $ messageBody��6)   $	 * 6>   
 6H   �� *messageBody+5%      �� 5&      -   5         ��Name$ topicBox��5&      $
��Left=�6(   $��33��6C   $��	44,47,0,0q�6O   $��1��6b   $	��Top=�6o   $	��231��6�   �� 5'      -   5         ��Name$ txtMessageBox��5'      $
��Left=�6-   $	��125��6H   $��962,140,0,0q�6U   $��1��6j    �� TextWrapping$
 Wrap=�6w   $�� ��6�   $	��Top=�6�   $	��220��6�   �� 5(      -   5        $ txtSubjectType��5(      $
��Left=�6.   $��51��6I   $��1011,351,0,0q�6U   $��1��6k   $
 Wrap=�6x   $�� ��6�   $	��Top=�6�   $	��123��6�   �� 5)      -   5         ��Name$ button��5)      $��Send Message��6%   $
��Left=�6<   $��1018,440,0,0q�6W   $��1��6m   $	��Top=�6z   $	��116��6�   $��40��6�   6�   �� 5*      -   5         ��Name$ label��5*      $��Enter the Message��6#   $
��Left=�6?   $��1018,80,0,0q�6Z   $��1��6o   $	��Top=�6|   $��60��6�   $	��139��6�   �� 5+      -	   5        $ label1��5+      $��Enter the subject��6$   $
��Left=�6@   $��1018,304,0,0q�6[   $��1��6q   $	��Top=�6~   $��42��6�   $	��116��6�   5,      52      53      