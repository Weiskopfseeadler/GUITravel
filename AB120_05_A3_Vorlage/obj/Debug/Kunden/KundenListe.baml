   M S B A M L   `   `   `  ����N  JAB120_05_A3_Vorlage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AB120_05_A3_VorlageAB120_05_A3_Vorlage  5      %    AB120_05_A3_Vorlage.KundenListe   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:AB120_05_A3_Vorlage     5      ���	#FFBCBCBC.��5	      �   � ColumnDefinitions  5
   
   �� 5      $	��33* �6   �� 5      $	��32* �6   �� 5      $	��35* �6    � RowDefinitions 5   
   �� 5      $	��61* �6   �� 5      $
��239* �6   .+�5   
   �� -   5         ��Name$	 New��5      $��5,5,5,5q�6   ���	#00DDDDDD$��0q�6X   .��5      �� $��Add.jpg��6   $��Uniform=�6&   5      �� 5   
   -   5        $��Delete��5      $��5,5,5,5q�6   $��2��60   ���	#00DDDDDD$��0q�6l   .��5      �� $��
Delete.jpg��6   $��Uniform=�6(   $��0,0,0,0q�6:   6O   5      �� 5   
   -   5        $
��Edit��5      $��5,5,5,5q�6   $��1��60   ���	#00DDDDDD$��0q�6j   .��5      �� $��download.png��6   $��Uniform=�6*   $��0,0,0,0q�6<   6Q   5      ]� 5   
   ��. $��1��6)   $��3��66   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ lb��5    S      CanUserResizeColumns .    CanUserResizeRows .     MinRowHeight$ 40Q�6%      AutoGenerateColumns .  $��0,0,0,0q�6_      Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn	   
IsReadOnly	 . 
   Header$
 Anrede��6]      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6u   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Anrede+6u     5#      	 . $

 Name��6]   $ * 6u    6;   �� *Name+6u     5$      	 . $
 Vorname��6]   $ * 6u    6;   �� *	Vorname+6u     5%      	 . $
 
NameZusatz��6]   $ * 6u    6;   �� *
NameZusatz+6u     5&      	 . $
 KundeID��6]   $ * 6u    6;   �� *	KundeID+6u     5'      	 . $
 	StrasseNr��6]   $ * 6u    6;   �� *	StrasseNr+6u     5(      	 . $	
 PLZ��6]   $ * 6u    6;   �� *PLZ+6u     5)      	 . $	
 Ort��6]   $ * 6u    6;   �� *Ort+6u     5*      	 . $
 Telefon��6]   $ * 6u    6;   �� *	Telefon+6u     5+      	 . $
 Mobile��6]   $ * 6u    6;   �� *Mobile+6u     5,      	 . $	
 Web��6]   $ * 6u    6;   �� *Web+6u     5-      	 . $
 Email��6Y   $ * 6q    6;   �� *Email+6q     5.      	 . $
 PassNr��6Y   $ * 6q    6;   �� *PassNr+6q     5/      	 . $
 Nationalitaet��6]   $ 2* 6u    6;   �� *Nationalitaet+6u   51      52      54      55      