   M S B A M L   `   `   `  ����C  ?spookify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:spookifyspookify  5   	       spookify.UpdateWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:spookify     5   	   A =Wpf.Ui, Version=3.0.4.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5   	     � Title$  UpdateWindow��5	   	   $	��384��6   $	��384��6+    � WindowStartupLocation$ CenterScreen=�5
   	   ���#F3F3F3 � 	Resources 5        Wpf.Ui.Controls.TextBlock �� 
TargetType �� Property �� Value��%T   '        �� 5   
   "  6   .�5      ��  � ��
 �   �6+   5      5      .��5      � $��16q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
     $��0��6   $��Update a song��6$   $��24(�69   $
��Bold"�6G   $��0,0,0,16q�6Y   $��Center=�6k   � 5   
   $��1��6   $��0q�6   $��Center=�6'    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    .+�5$        $��0��6   $��0��6(   $��Title��68   $
��Bold"�6E   $��Center=�6W     Wpf.Ui.Controls.TextBox  5%      -   5          Name$ 	nameInput��5%      $��0��6,   $��1��69   $��16,0,0,8q�6l   ��6I   �� *name+	 �� Mode$	 TwoWay=�6l     5&      $��1��6   $��0��6(   $��Artist��68   $
��Bold"�6F   $��Center=�6X     5'      -   5        $ artistInput��5'      $��1��6.   $��1��6;   $��16,0,0,8q�6p   ��6K   �� *artist+$	 TwoWay=�6p     5(      $��2��6   $��0��6(   $��Album��68   $
��Bold"�6E   $��Center=�6W     5)      -   5        $ 
albumInput��5)      $��2��6-   $��1��6:   $��16,0,0,8q�6n   ��6J   �� *album+$	 TwoWay=�6n     5*      $��3��6   $��0��6(   $��	File name��68   $
��Bold"�6I   $��Center=�6[     5+      -   5        $ filenameInput��5+      $��3��60   $��1��6=   $��16,0,0,8q�6t   ��6M   �� *
filename+$	 TwoWay=�6t   5,        Wpf.Ui.Controls.Button  5-   
   -   5        $��2��5-      $��Update��6!   ���#005FB8
�������$��16(�6Z   $��Cairo)�6h   $��SemiBold"�6{   $��Center=�6�   $��Center=�6�   $��0q�6�   
   MouseOverBackground
 5.      �� 5/       �� Color$ #004C9A��6"      PressedBackground 51      �� 52      $ #003F80��6"      PressedForeground 54      �� 55      $ White��6"   57      58      59      