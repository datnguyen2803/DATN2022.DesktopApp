   M S B A M L   `   `   `  ????U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5      C ?DataView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DataViewDataView 5         DataView.PumpMenuWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5      "localclr-namespace:DataView  5      _ [MaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $??pumpMenuWindow??5        ? Title$  
Thông tin??5
      $	??450??6   $	??800??6"    
  PumpVM ? DataContext# [  5        MaterialDesignBody#???  5      $??Regular"?5      $??13(?5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5         TextRenderingMode$
 Auto=?5        MaterialDesignPaper#???  5        MaterialDesignFont#???  5       ? WindowStartupLocation$ CenterScreen=?5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded??6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   ?? *LoadedWindowCommand+	   CommandParameter	 6L   ?? 
 ?? ElementName$
 pumpMenuWindow??5       ? 	Resources 5        PumpCard ?? 
TargetType#  MaterialDesignThemes.Wpf.Card ?? Property ?? Value  CardTitleText  CardBodyText??%s  &	       &	 ?     &	     ?? 5!   
   "  6!   .?5"      ??  ? ??$ 10q?6'   ?? 5#       ? ??$ 8 8 8 8q?6(   ?? 5$       ? ?? ?#ede7f66+   ?? 5%       ? ?? ?#1a237e6+   5&      ?? 5(   
   " ??6&   .?5)      ??  ? ??$ 30(?6)   5*      ?? 5,   
   " ??6%   .?5-      ??  ? ??$ 16(?6)   5.      50      .??53      ?  ? ColumnDefinitions 54   
   ?? 55      $
??auto ?6   6.   ?? 56      6!   .+?58   
   ? $??0??6   $
??Left=?6   .+?59        .??5:      ?? .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Standard=?5;      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp0=?5<       * &MaterialDesignNavigationRailTabControl#??[ 5=      .@?5>      ?? ??5?      ?? 5@      $
??auto??6)   $
??auto??66   .+?5A   "   '	  !MaterialDesignThemes.Wpf.PackIcon	  $??24??5B   
   $??24??5C   
   $??Center=?5D   
    	  Kind$ ClockOutline=?5E   
   ?? 5F   "   $??Center=?6,   $??Hiện tại??6I   5G      5I      ?? 5J      -   5        ??5K      ?? 5L      $
??auto??6)   $
??auto??66   .+?5M   "   	  $??24??5N   
   $??24??5O   
   $??Center=?5P   
   $ HomeSearchOutline=?5Q   
   ?? 5S   "   $??Center=?6,   $??	Khu vực??6I   5T      5V      ?? 5W      ??5X      ?? 5Y      $
??auto??5Z      $
??auto??5[      .+?5\   "   	  $??24??5]      $??24??5^      $??Center=?5_      $ InformationOutline=?5`      ?? 5a   "   $??Center=?5b      $??About??5c      5d      5f      ?? 5g      ??5h      ?? 5i      $
??auto??5j      $
??auto??5k      .+?5l   "   	  $??24??5m      $??24??5n      $??Center=?5o      $ 	ExitToApp=?5p      ?? 5q   "   $??Center=?5r      $??Thoát??5s      5t      5v      5w      5x      5y      ? 5{   
   $??1??6    ? RowDefinitions 5|      ?? 5}      $??2* ?6    6.   ?? 5~      $??8* ?6    6.   .+?5?      ?? $??0??5?       $  MaterialDesignHeadline4TextBlock#??[ 5?      $??Center=?5?      $??Center=?5?      $??Thông tin máy bơm??5?      ? 5?      $??1??6    5?      ?? 5?      $??4* ?6'   64   ?? 5?      $??6* ?6'   64   .+?5?        $??0??6&   $	??240??5?      #??[ 5?      .??5?      ?  5?      ?? 5?      $	??100 ?6,   ?? 5?      $??5* ?6,   ?? 5?      $??2* ?6,   .+?5?      ?? $??1??6!   $??5,20,5,0q?6.   .+?5?      ?? $
??Bold"?5?      $??20(?5?      Máy bơm 015?      ?? 5?      $??Center=?5?      $
??Wrap=?5?      
Trạm A5?      ?? 5?      $??Center=?5?      $
??Wrap=?5?      Trạng thái: Bật5?      5?      `? 5?      $??2??6"   $??0q?6/   .?5?      c? $	??230??6"   .@?5?      ?? .??5?   "   	  $ Information=?6:   $??Center=?6M   $??Center=?6j   5?      ?? 5?      .??5?   "   	  $ Pencil=?6:   $??Center=?6H   $??Center=?6e   5?      ?? 5?      .??5?   "   	  $ Delete=?6:   $??Center=?6H   $??Center=?6e   5?      5?      5?      5?      5?      ? 5?      $??1??6    5?      ?? 5?      $??2* ?6(   66   ?? 5?      $??8* ?6(   66   .+?5?      ?? $??0??5?       $	  MaterialDesignHeadline6TextBlock#??[	 5?      $??Center=?5?      $??Center=?5?      $*??$Thời gian hoạt động trong 24h??5?      
   LiveCharts.Wpf.PieChart
  5?      $??1??6#   $??20q?60   &    LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Right=?6d      	Hoverable$ False??6{    
  InnerRadius$ 0Q?6?      Series 6<   ?? *pumpSeriesCollection+   ChartLegend 5?      "   LiveCharts.Wpf.DefaultLegend  5?         
BulletSize$ 15Q?60   $??15(?6@   6Z      DataTooltip 5?      #   LiveCharts.Wpf.DefaultTooltip  5?         
BulletSize$ 20Q?61   6C   5?      5?      5?      5?      5?      5?      