   M S B A M L   `   `   `  ????U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5      C ?DataView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DataViewDataView 5         DataView.GraphWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5      "localclr-namespace:DataView  5      _ [MaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $??graphWindow??5        ? Title$  Biểu đồ trạm??5
      $	??450??6   $	??800??6%      	StationVM ? DataContext# [  5        MaterialDesignBody#???  5      $??Regular"?5      $??13(?5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5         TextRenderingMode$
 Auto=?5        MaterialDesignPaper#???  5        MaterialDesignFont#???  5       ? WindowStartupLocation$ CenterScreen=?5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded??6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   ?? *LoadedWindowCommand+	   CommandParameter	 6L   ?? 
 ?? ElementName$
 graphWindow??5       ? 	Resources 5        TableHeaderTextBlock ?? 
TargetType ?? Property ?? Value  TableCellTextBlock??%4  &	       &	 ?     ?? 5!   
   " ??6-   .?5"      ??  ? ??$ 15(?6)   ?? 5#       ?@??TextAlignment$
 Left=?6.   ?? 5$       ? ??$
 Bold"?6+   5%      ?? 5'   
   " ??6+   .?5(      ??  ? ??$ 15(?6)   ?? 5)       ?@??TextAlignment$ Center=?6.   5*      5,      .??5/      ?  ? ColumnDefinitions 50   
   ?? 51      $
??auto ?6   6.   ?? 52      6!   .+?54   
   ? $??0??6   $
??Left=?6   .+?55      #  MaterialDesignThemes.Wpf.Card  .??56      ?? .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Standard=?57      .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp0=?58       * &MaterialDesignNavigationRailTabControl#??[ 59      .@?5:      ?? ??5;      ?? 5<      $
??auto??6)   $
??auto??66   .+?5=   "   '	  !MaterialDesignThemes.Wpf.PackIcon	  $??24??5>   
   $??24??5?   
   $??Center=?5@   
    	  Kind$ ClockOutline=?5A   
   ?? 5B   "   $??Center=?6,   $??Hiện tại??6I   5C      5E      ?? 5F      ??5G      ?? 5H      $
??auto??6)   $
??auto??66   .+?5I   "   	  $??24??5J   
   $??24??5K   
   $??Center=?5L   
   $ HomeSearchOutline=?5M   
   ?? 5N   "   $??Center=?6,   $??	Khu vực??6I   5O      5Q      ?? 5R      ??5S      ?? 5T      $
??auto??5U      $
??auto??5V      .+?5W   "   	  $??24??5X      $??24??5Y      $??Center=?5Z      $ InformationOutline=?5[      ?? 5\   "   $??Center=?5]      $??About??5^      5_      5a      ?? 5b      ??5c      ?? 5d      $
??auto??5e      $
??auto??5f      .+?5g   "   	  $??24??5h      $??24??5i      $??Center=?5j      $ 	ExitToApp=?5k      ?? 5l   "   $??Center=?5m      $??Thoát??5n      5o      5q      5r      5s      5t      ? 5v   
   $??1??6    ? RowDefinitions 5w      ?? 5x      $??2* ?6    6.   ?? 5y      $??8* ?6    6.   .+?5|      ?? $??0??5}       $  MaterialDesignHeadline4TextBlock#??[ 5~      $??Center=?5      $??Center=?5?      $??Thông tin trạm A??5?      ? 5?      $??1??6    5?      ?? 5?      $??5* ?6'   64   ?? 5?      $??5* ?6'   64   .+?5?      ? $??0??6    5?      ?? 5?      $??* ?6(   65   ?? 5?      $??* ?6(   65   ?? 5?      $??8* ?6(   66   .+?5?      ?? $??0??6!   $??5q?6.    ?? Orientation$ 
Horizontal=?69   .+?5?      ?? $??15(?6$   $??Địa chỉ: ??62   ?? 5?      $??15(?6$   $??
Hà Đông??62   5?      ?? 5?      $??1??6!   $??5q?6.   $ 
Horizontal=?69   .+?5?      ?? $??15(?6$   $??Tổng số máy: ??62   ?? 5?      $??15(?6$   $??6 ??62   ?? 5?      $??15(?6$   $??- Bật??62   ?? 5?      $??15(?6$   $?? (3) ??62   ?? 5?      $??15(?6$   $??- Tắt??62   ?? 5?      $??15(?6$   $
?? (3)??62   5?      ?? 5?      $??2??6   $??0 0 0 10q?6,   ??6>   ?? *
MyPumpList+ ?? View 5?      ?? 5?      .P?5?   "   ??  ?? Width$
 auto??5?      ??5?   &   ?? 5?   *   #??[ 64   $	??STT??6b    ?? CellTemplate 5?   &   ?? 5?   *   .R?5?   .   ?? #??[ 68   $??40??6d   ??6o   ?? *Id+5?   +   5?   #   ?? 5?   "   $
 auto??5?      ??5?   &   ?? 5?   *   #??[ 64   $
??Máy??6b    5?   &   ?? 5?   *   .R?5?   .   ?? #??[ 68   $??40??6d   ??6o   ?? *Name+5?   +   5?   #   ?? 5?   "   $
 auto??5?      ??5?   &   ?? 5?   *   #??[ 64   $??Trạng thái??6b    5?   &   ?? 5?   *   .R?5?   .   ?? #??[ 68   $??50??6d   ??6o   ?? *State+5?   +   5?   #   5?      5?      5?      ? 5?      $??1??6    5?      ?? 5?      $??2* ?6(   66   ?? 5?      $??8* ?6(   66   .+?5?      ?? $??0??5?       $  MaterialDesignHeadline6TextBlock#??[ 5?      $??Center=?5?      $??Center=?5?      $'??!Biểu đồ tình trạng trạm??5?      #
   LiveCharts.Wpf.CartesianChart
  5?      $??5q?6)   $??1??64   &    LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Bottom=?6h      Series 6A   ?? *pumpStateCollection+   AxisX 5?         LiveCharts.Wpf.Axis     Title$ Thời gian??6'      Labels 69   ?? *Labels+6U      AxisY 5?        $ Số lượng??6'      LabelFormatter 68   ?? *	Formatter+6_   5?      5?      5?      5?      5?      5?      