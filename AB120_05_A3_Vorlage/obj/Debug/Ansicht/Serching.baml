   M S B A M L   `   `   `  ����N  JAB120_05_A3_Vorlage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:AB120_05_A3_Vorlage.AnsichtAB120_05_A3_Vorlage.Ansicht  5      *    $AB120_05_A3_Vorlage.Ansicht.Serching   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:AB120_05_A3_Vorlage.Ansicht     5      ���	#FF2D692D.��5      �   � ColumnDefinitions  5	   
   �� 5
      $��1 �6   �� 5      $
��179* �6   �� 5      $
��350* �6   �� 5      $
��195* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��7* �6   .+�5   
   �� $��	GIUTravel��6   $
��Left=�6$   $��	12,10,0,0q�6?   $	��Top=�6R   $��54.921��6j   $��175.593��6z   $��36(�6�   $��2��6�   $��1��6�   �� 5   
   -   5        $��
Serchfield��5      $
��Left=�6$   $��37.553��6?   $��0,27.368,0,0q�6O    �� TextWrapping$
 Wrap=�6e   $��Suche��6y   $	��Top=�6�   $��345.283��6�   $��2��6�   �� 5   
   -   5        $��Serch��5   &   $��3��66   $
��Left=�6F   $��0.818,27.368,0,0q�6a   $	��Top=�6{   $��53.491��6�   $��37.553��6�   ]� 5   
   $��1��6   $
��Left=�6$   $��184.155��6?   ��.  $��59.78,31.429,0,0q�6f   $��1��6�   $	��Top=�6�   $��555.065��6�   $��3��6�   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ lb��5   s      CanUserResizeColumns .    HeadersVisibility$
 None=�5   4      CanUserResizeRows .     MinRowHeight$ 40Q�5   %      AutoGenerateColumns .  $��0,0,0,0q�6   ���	#0001FFFF��6S   �� *Hotels+	   Columns	 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Image��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6<      
IsReadOnly .    CellTemplate 5      �� 5      .R�5   "   �� ��6(   �� *Image+5       5"      0  *System.Windows.Controls.DataGridTextColumn  5#      1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *Name+5%      5&      �� 5'   
   -   5         ��Name$ Close��5'      $��ChekPassWordForClosee��6    $��1��6@   $
��Left=�6P   $��12,248.44,0,0q�6k   $��1��6�   $	��Top=�6�   $
��45.4��6�   $��21.56��6�   6�   5)      5*      