   M S B A M L   `   `   `  ����C  ?DataView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DataView.ViewDataView.View  5      #    DataView.View.StationMenuView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:DataView.View     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      _ [MaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5          >�Name$  stationMenuView��5         	StationVM � DataContext# [  5        MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � 	Resources 5        PumpCard �� 
TargetType#  MaterialDesignThemes.Wpf.Card �� Property �� Value  CardTitleText  CardBodyText��%�  &	       &	 
    &	 R    �� 5   
   "  6!   .�5      ��  � ��$	 180��6&   �� 5       � ��$ 80��6'   �� 5       � ��$ 10q�6'   �� 5       � ��$ 8 8 8 8q�6(   �� 5       � ��
 �����6+   �� 5       � �� �#1a237e6+   5       �� 5"   
   " ��6&   .�5#      ��  � ��$ 30(�6)   5$      �� 5&   
   " ��6%   .�5'      ��  � ��$ 16(�6)   5(      5*      .��5-      � $��1��6    � RowDefinitions 5.   
   �� 5/      $
��1.5* �6   6,   �� 50      $
��1.5* �6   6,   �� 51      $
��1.5* �6   6,   �� 52      $��7* �6   6*   �� 53      $
��auto �6   6,   .+�57   
   � $��0��6   $��40��6   $	��Top=�6(   .+�58      ��  $  MaterialDesignHeadline4TextBlock#��[ 59      $��Center=�5:      $��Center=�5;      $��Theo dõi trạng thái��5<      5=      � 5@   
   $��1��6   $��5q�6   	 � ColumnDefinitions	 5A      �� 5B      $��8* �6#   60   �� 5C      $��* �6#   6/   �� 5D      $��* �6#   6/   .+�5G      �� $��0��6   $��10 0 0 0q�6&   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Tìm theo tên��68   �� 5H      $��1��6   $
��auto��6%   $��Right=�62   $��0 0 10 0q�6N   .��5I      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Magnify=�6*   5J      �� 5K      $��2��6   $
��auto��6%   $��Right=�62   $��0 0 10 0q�6N   .��5L        $ FilterMenuOutline=�6*   5M      5O      � 5R   
   $��2��6   $��40��6   $	��Top=�6(   .+�5S      ��  $  MaterialDesignHeadline5TextBlock#��[ 5T   	   $
��Left=�5U      $��10 0 0 0q�5V      $��Center=�5W      $��Trạm A��5Y   	   5Z      � 5]   
   $��3��6   .+�5^      �� ��6   �� *
MyPumpList+��5_      �� 5`      .R�5a      � 5b      ��5d      �� 5e      .R�5f      � $��Stretch=�6   $��3q�6=   $
��Auto��6H    5g      �� 5h   "   $��* �60   �� 5i   "   $��* �60   	 5k      �� 5l   "   $��* �63   �� 5m   "   $��* �63   �� 5n   "   $��* �63   .+�5q        #��[ 5r      ��6?   �� *PColor+.��5s   "   �� .+�5t   &   �� #��[ 60   ��6W   �� *Name+6o   �� 5u   &   #��[ 60   ��6V   �� *State+6o   5v   #   5w      5x      5y      5{      5�      � 5�   
   $��4��6   .+�5�      �� $��50��6   $��50��6     /	 +MaterialDesignFloatingActionMiniLightButton#��[	 5�       � ToolTip$1 +MaterialDesignFloatingActionMiniLightButton��5�      $��Right=�6I   $��0,10, 10,10q�6e   .��5�        $
 Plus=�6*   $��25��66   $��25��6B   5�      �� 5�      $��50��6   $��50��6    #��[	 5�      $1 +MaterialDesignFloatingActionMiniLightButton��5�      $��Right=�6I   $��0,10, 80,10q�6e   .��5�        $ 	ChartLine=�6*   $��25��6;   $��25��6G   5�      5�      5�      5�      