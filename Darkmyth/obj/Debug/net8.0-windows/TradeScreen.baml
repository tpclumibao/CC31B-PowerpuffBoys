   M S B A M L   `   `   `  ����N  JCC31B-PowerpuffBoys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CC31B_PowerpuffBoysCC31B_PowerpuffBoys  5   	   %    CC31B_PowerpuffBoys.TradeScreen   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CC31B_PowerpuffBoys     5   	     � WindowStartupLocation$  CenterOwner=�5   	   $
��11pt(�5	   	    � Title$ Trade Screen��5
   	   $	��480��6   $	��640��6+   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��2��5      $��Center=�5      ��5      �� *CurrentTrader.Name+�� 5   
   $��1��6   $��0��6   $��Center=�5      $��Your Inventory��5      �� 5    
   $��1��6   $��1��6   $��Center=�5!      $��Trader's Inventory��5"      &   System.Windows.Controls.DataGrid  5$   
   $��2��6   $��0��6    $��10q�5%         AutoGenerateColumns$ False��5'         HeadersVisibility$ Column=�5(         CanUserAddRows$ False��5)         CanUserDeleteRows$ False��5*      "   VerticalScrollBarVisibility$
 Auto=�5+      ��5&      �� * CurrentPlayer.GroupedInventory+	   Columns	 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Description��6%      
IsReadOnly$
 True��5.   %      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5/   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 50   %   ��  �� Path$ 	Item.Name�  51      $	
 Qty��6%   $
 True��52   %   $
 Auto 53   %    54   %   �� *
Quantity+  55      $
 Price��6%   $
 True��56   %   $
 Auto 57   %    58   %   �� $ 
Item.Price�4  .System.Windows.Controls.DataGridTemplateColumn  59         MinWidth$ 75Q�6)      CellTemplate 5:      �� 5;      .R�5<      �� -   5        $��55��5=   %   $��Sell 1��5>   %   5?      5A      5C        5D   
   $��2��6   $��1��6    $��10q�5E      $ False��5G      $ Column=�5H      $ False��5I      $ False��5J      $
 Auto=�5K      ��5F      �� * CurrentTrader.GroupedInventory+	 5L        5M      $
 Description��6%   $
 True��5N   %   $ * 5O   %    5P   %   �� $ 	Item.Name�  5Q      $	
 Qty��6%   $
 True��5R   %   $
 Auto 5S   %    5T   %   �� *
Quantity+  5U      $
 Price��6%   $
 True��5V   %   $
 Auto 5W   %    5X   %   �� $ 
Item.Price�  5Y      $ 75Q�6)    5Z      �� 5[      .R�5\      �� -   5        $��55��5]   %   $��Buy 1��5^   %   5_      5a      5c      �� 5d   
   -   5        $��3��5d      $��1��6   $��Right=�5e      $��75��5f      $��Close��5g      5h      5i      5j      