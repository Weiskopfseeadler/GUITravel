   M S B A M L   `   `   `  ����N  JAB120_05_A3_Vorlage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AB120_05_A3_VorlageAB120_05_A3_Vorlage  5      9!clr-namespace:AB120_05_A3_VorlageAB120_05_A3_Vorlage  5      -    'AB120_05_A3_Vorlage.HotelAdministration   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2self!clr-namespace:AB120_05_A3_Vorlage     5      3local!clr-namespace:AB120_05_A3_Vorlage     5      ���	#FFBCBCBC  � 	Resources  5      '   !AB120_05_A3_Vorlage.DumiConverter   DumiConverter��%   &	          5   
   6   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��33* �6   �� 5      $	��32* �6   �� 5      $	��35* �6    � RowDefinitions 5   
   �� 5      $	��61* �6   �� 5      $
��239* �6   .+�5   
   �� -   5         ��Name$	 New��5      $��5,5,5,5q�6   ���	#00DDDDDD$��0q�6Z   .��5      �� $3��-/AB120_05_A3_Vorlage;component/Kunden/Add.jpg��6   $��Uniform=�6K   $��0,0,0,0q�6]   6r   5      �� 5   
   -   5        $��Delete��5      $��5,5,5,5q�6   $��2��60   ���	#00DDDDDD$��0q�6l   .��5      �� $6��0/AB120_05_A3_Vorlage;component/Kunden/Delete.jpg��6   $��Uniform=�6N   $��0,0,0,0q�6`   6u   5      �� 5   
   -   5        $
��Edit��5      $��5,5,5,5q�6   ���	#00DDDDDD$��0q�6E   $��1��6Y   .��5       �� $8��2/AB120_05_A3_Vorlage;component/Kunden/download.png��6   $��Uniform=�6P   $��0,0,0,0q�6b   6w   5!      ]� 5"   
   $��3��6   $��0,0,0,0q�6(   ��. $��1��6N   
�������.+�5$      &   System.Windows.Controls.DataGrid  -   5          Name$ lb��5%   S      CanUserResizeColumns .    CanUserResizeRows .     MinRowHeight$ 40Q�6%      AutoGenerateColumns .  $��0,0,0,0q�6_   	   Columns	 5&      4  .System.Windows.Controls.DataGridTemplateColumn  5'      -   5        TemplatColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 Image��5'   D      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6S      
IsReadOnly .    CellTemplate 5(      �� 5)      .R�5*   "   ��  ��Name$ image��6(   ��67   �� *BitmapImage+ �� 	Converter# [  5+      5-      0  *System.Windows.Controls.DataGridTextColumn  5.      $
 HotelID��6E   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *	HotelID+6E     5/      $
 Name   ��6E    6)   �� *Name+6E     50      $
 Ort    ��6E    6)   �� *Ort+6E     51      $
 Land   ��6E    6)   �� *Land+6E     52      $
 Sterne ��6E    6)   �� *Sterne+6E     53      $
 Manager��6E    6)   �� *	Manager+6E     54      $
 AnzahlZ��6E    6)   �� *	AnzahlZ+6E     55      $
 TagesPr��6E    6)   �� *	TagesPr+6E     56      $
 Telefon��6E    6)   �� *	Telefon+6E     57      $
 Email  ��6E    6)   �� *Email+6E     58      $
 Web    ��6E    6)   �� *Web+6E   5;      5<      5>      5?      