   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5   	       ExpenseIt.ExpenseItHome   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ExpenseIt     5   	     � Title$  ExpenseIt - Home��5   	   $	��450��6"   $	��800��6/   .��5	      � $��
10,0,10,10q�6   ��5
   
   �� 5       �� ImageSource$M GC:\Users\Iveli\source\repos\PS_52_IvelinNikolov\ExpenseIt\watermark.png��6    � ColumnDefinitions 5   
   �� 5      �� 5      $	��230 �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��1��6   ��6    ��  �� RelativeSource ��  �� AncestorType" � �� Path$ MainCaptionText�6�   �� 5   
   $��35��6    �� Padding$ 5q�6   $��1��6)   $��1��69   ���#4E87D4$��
0,10,10,10q�6[   ._�5      �� $��Center=�6   $��Names��6/   $��Normal"�6?   $��Normal$�6S   
�������6f   5      �� 5   
   -   5        $��peopleListBox��5      $��1��6[   $��2��6k   $��0,0,10,0q�6x   ��6�   ��  �� " �$ ExpenseDataSource���5      �� 5      .R�5      �� ��6   �� $
 Name�5       5"      �� 5#   
   -   5         ��Name$ btnView��5#      $��1��6"   $��3��62   $	��125��6�   $��20��6�   $��Right=�6�   $��
0,20,10,20q�6�   ��6?   �� 	 �� ElementName$	 peopleListBox��$ SelectedItem.Name�6�   �� 5$   
   $��0��6   $��2��6"   ��6/   �� $ PersonsChecked�6]   �� 5%   
   $��0��6   $��3��6    $
��Bold"�6R   ��6-   �� $ LastChecked�6R   5&      5'      