   M S B A M L   `   `   `  ����N  JAB120_05_A3_Vorlage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AB120_05_A3_Vorlage.ReiseAB120_05_A3_Vorlage.Reise  5      4    .AB120_05_A3_Vorlage.Reise.TravelAdministration   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:AB120_05_A3_Vorlage.Reise     5      
��� ���.��5      �   � ColumnDefinitions  5	   
    � RowDefinitions 5   
   �� 5      $��9* �6   �� 5      $	��43* �6   .+�5   
   ]� ��. $��1��6)   $��3��66   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ lb��5   S      CanUserResizeColumns .    CanUserResizeRows .     MinRowHeight$ 40Q�6%      AutoGenerateColumns .  $��0,0,0,0q�6_      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly . 	   Header$	  ReiseID     ��6]   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6x   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *	ReiseID+6x     5       . $	  Land        ��6]   $
 * 6x    6;   �� *Land+6x     5       . $	  Start       ��6]   $
 * 6x    6;   �� *Start+6x     5       . $	  Ende        ��6]   $
 * 6x    6;   �� *Ende+6x     5       . $	  Preis       ��6]   $
 * 6x    6;   �� *Preis+6x     5       . $	  Leitung     ��6]   $
 * 6x    6;   �� *	Leitung+6x     5       . $	  NameLeitung ��6]   $
 * 6x    6;   �� *NameLeitung+6x   5       5!      o� 5"   
   $��0��6   $��0,0,0,0q�6   .@�5#      m� $��0,0,0,0q�6   $��MenuItem��6-   .@�5$      m� $
��_New��6   m� 5%      $��_Open��6   m� 5&      $��_Save��6   �� 5'      m� 5(       m� StaysOpenOnClick . $��_Exit��63   5)      m� 5*       . $��MenuItem��6/   $��1��6A   5+      5,      5.      