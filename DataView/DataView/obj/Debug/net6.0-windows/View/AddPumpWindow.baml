   M S B A M L   `   `   `  ????C  ?DataView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DataViewDataView  5   	       DataView.AddPumpWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DataView     5   	   _ [MaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        ? Title$  Thêm máy bơm??5   	   $	??450??6   $	??800??6+      MaterialDesignBody#???   5      $??Regular"?5      $??13(?5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5         TextRenderingMode$
 Auto=?5        MaterialDesignPaper#???  5        MaterialDesignFont#???  5       ? WindowStartupLocation$ CenterScreen=?5      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      6!   .+?5   
   ? $??0??6   $??	0,0,328,0q?6   .+?5      #  MaterialDesignThemes.Wpf.Card  .??5      ?? .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Standard=?5      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp0=?5       * &MaterialDesignNavigationRailTabControl#??[ 5      .@?5      ?? ??5       ?? 5!      $
??auto??6)   $
??auto??66   .+?5"   "   '  !MaterialDesignThemes.Wpf.PackIcon  $??24??5#   
   $??24??5$   
   $??Center=?5%   
      Kind$ ClockOutline=?5&   
   ?? 5'   "   $??Center=?6,   $??Hiện tại??6I   5(      5*      ?? 5+      ??5,      ?? 5-      $
??auto??6)   $
??auto??66   .+?5.   "     $??24??5/   
   $??24??50   
   $??Center=?51   
   $ HomeSearchOutline=?52   
   ?? 53   "   $??Center=?6,   $??	Khu vực??6I   54      56      ?? 57      ??58      ?? 59      $
??auto??5:      $
??auto??5;      .+?5<   "     $??24??5=      $??24??5>      $??Center=?5?      $ InformationOutline=?5@      ?? 5A   "   $??Center=?5B      $??About??5C      5D      5F      ?? 5G      ??5H      ?? 5I      $
??auto??5J      $
??auto??5K      .+?5L   "     $??24??5M      $??24??5N      $??Center=?5O      $ 	ExitToApp=?5P      ?? 5Q   "   $??Center=?5R      $??Thoát??5S      5T      5V      5W      5X      5Y      ? 5[   
   $??2??6   $??72,0,0,0q?6#    ? RowDefinitions 5\      ?? 5]      $
??auto ?6    60   ?? 5^      $
??auto ?6    60   .+?5a      ? $??0??6   $??40??6    $	??Top=?6,   .+?5b      ??  $  MaterialDesignHeadline4TextBlock#??[ 5c      $??Center=?5d      $??Center=?5e      $??Thêm máy bơm??5f      5g      5h      5i      5j      