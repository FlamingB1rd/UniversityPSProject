   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5   	       ExpenseIt.ExpenseReport   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ExpenseIt     5   	     � Title$  ExpenseIt - View Expense��5   	   $	��450��6*   $	��800��67   .��5	      � $��
10,0,10,10q�6   ��5
   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��1��6    � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      � $��3��6    5      �� 5      $
��Auto �6$   �� 5      $��* �6$    5      �� 5      $��* �6'   �� 5       $��* �6'   .+�5#      �� $��0��6   $��0��6)   $��35��66    �� Padding$ 5q�6B   ���	#FF6B1CC9._�5$      �� $��Center=�6   $��Expense Type��67   $��Normal"�6N   $��Normal$�6b   
�������6u   5%      �� 5&      $��1��6   $��0��6)   $��35��66   $ 5q�6B   ���	#FF6B1CC9._�5'      �� $��Center=�6   $��Amount��67   $��Normal"�6H   $��Normal$�6\   
�������6o   5(      5)      � 5*      $��5��6   .+�5+      &   System.Windows.Controls.DataGrid  $��1��6      AutoGenerateColumns$ False��6U      RowHeaderWidth$ 0Q�6q   ��6/   ��  �� Path$ Expenses�   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ExpenseType Sort��6-   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6G   �� $ ExpenseType�  5.      $	 Amount Sort��6-   
 6B   �� $ ExpenseAmount�50      51      �� 53      $��0��6   ���	#FF0740A4$��22(�68   .��6F   Expense Report For:6[   �� 54      $��1��6   $
��Left=�6!   $
��Bold"�6<   $��14(�6N   .��6]   Name:6d   �� 55      $��1��6   $	��100��6!   $��Right=�6-   ��6I   �� $
 Name�6i   �� 56      $��2��6   $
��Left=�6!   $
��Bold"�6<   $��14(�6N   .��6]   Department:6j   �� 57      $��2��6   $	��100��6!   $��Right=�6-   ��6I   �� $ 
Department�6o   58      59      5:      