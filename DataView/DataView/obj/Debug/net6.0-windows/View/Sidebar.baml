   M S B A M L   `   `   `  ����C  ?DataView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DataView.ViewDataView.View  5          DataView.View.Sidebar   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:DataView.View     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      _ [MaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	         	SidebarVM  � DataContext#  [  5        MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � $��0��6   $��Center=�6   .+�5   
   �� -   5         ��Name$ sideNavigate��5      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Standard=�5      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp0=�5       * &MaterialDesignNavigationRailTabControl#��[ 5      .@�5      �� -   5        $��tabItemHome��5      ��5      �� 5       $
��auto��6!   $
��auto��6.   .+�5!      '  !MaterialDesignThemes.Wpf.PackIcon  $��30��5"   
   $��30��5#   
   $��Center=�5$   
      Kind$ HomeOutline=�5%   
   �� 5&      $��Center=�6$   $��Trang chủ��6A   5'      5)      �� 5*      -   5        $��tabItemConfig��5*      ��5+      �� 5,      $
��auto��6!   $
��auto��6.   .+�5-        $��30��5.   
   $��30��5/   
   $��Center=�50   
   $ 
CogOutline=�51   
   �� 52      $��Center=�6$   $��Cấu hình��6A   53      55      �� 56      -   5        $��tabItemAbout��56      ��57      �� 58      $
��auto��59      $
��auto��5:      .+�5;        $��30��5<      $��30��5=      $��Center=�5>      $ InformationOutline=�5?      �� 5@      $��Center=�5A      $��
Thông tin��5B      5C      5E      �� 5F      -   5        $��tabItemQuit��5F      ��5G      �� 5H      $
��auto��5I      $
��auto��5J      .+�5K        $��30��5L      $��30��5M      $��Center=�5N      $ 	ExitToApp=�5O      �� 5P      $��Center=�5Q      $��Thoát��5R      5S      5U      5V      5W      5X      