   M S B A M L   `   `   `  ����L  HAccountantManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AccountantManagerAccountantManager  5   	   )    #AccountantManager.PortalOperaciones   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:AccountantManager     5   	     � Title$  PortalOperaciones��5   	   $	��439��6#   $	��800��60   ��5	      �� 5
   
    j� Stretch$ Uniform=�6   .��5      � ���	#FF99B4D1$��0,0,0,0q�6"   .+�5   
   �� $��Center=�6   $��16��61   $��	0,407,0,0q�6=   $	��Top=�6P   $	��800��6h   A� 5   
   $
��Left=�6   $	��343��6-   $��	10,30,0,0q�6:   
���   �$	��Top=�6\   $	��306��6t    �� StrokeEndLineCap$
 Flat=�6�   $��2��6�   ��5      �� 5       �� ImageSource$n h/stock-vector-woman-financial-accountant-vector-illustration-of-national-accountant-s-day-1525378253.jpg��6   5      � 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��
DGTrabajos��5   *      
IsReadOnly .  $
��Left=�6<   $	��165��6W   $��
340,32,0,0q�6d   $	��Top=�6x   $	��366��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Id Trabajo��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   ��  �� Path$ ID�  5      $ Nombre Trabajo��6)    6A   �� 	 �� Mode$	 TwoWay=�$ Nombre�  5      $ Costo��6)    68   �� $	 TwoWay=�$ Costo�5      5      5#      5$      