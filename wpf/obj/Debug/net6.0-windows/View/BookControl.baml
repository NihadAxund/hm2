   M S B A M L   `   `   `  ????>  :wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:wpf.Viewwpf.View  5          wpf.View.BookControl   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:wpf.View     5      U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5      $??80??5	   6   $	??120??6D   $	??120??6T   $??80??6d   
?????? .??5
      ?   ? RowDefinitions  5   
   ?? 5      $??8* ?6   ?? 5      $??2* ?6   .+?5   
   ?? ._?5      ?? $??80??6   $??0,0,0,35q?6   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ Resources\book.gif??61      	AutoStart$
 True??5         AnimateInDesignMode$
 True??5         RepeatBehavior$ 1??5      5      5      ?? 5   
   -   5        $??lbl_txt??5      $??2??6    $??0,60,0,0q?61   $??Center=?6C   $	??8.8(?6`   $??Algerian)?6o   ??5      ?? 5       ?? EndPoint$ 0.5,1&?6&    ?? 
StartPoint$ 0.5,0&?67   .??5      ?  ? Color$ 	#FF00B3FF??6#    ? Offset$ 1Q?65   ? 5      $ 	#FF0084FF??6#   5      .??5       	Book Name5      ?? 5    
   -   5        $??Count??5       $??2??6   $??0,75,0,0q?6/   $??Center=?6A   $??10(?6^   $??	Bodoni MT)?6l   ???	#DD00E3FF??6?   Z? .??6?   COUNT:5"      ?? 5#   
   $??1??6   	 ?? Orientation$	 
Horizontal=?6"   .+?5%      ?? -   5        $	??btn??5%   '   $??13??62   $??13??6=   $??17,0,0,0q?6I   ???	#FF5AFF00??5)      ?? 5*      
 ?? ImageSource$
 /View/Untitled-1.png??6!   5,      ?? 5-      -   5        $??	Count_txt??5-      $??20??6%   $??20??60   $??10(?6<   ???	#FF0084FF$
??Bold"?6a   .??6t   06w   ?? 5.      -   5        $??13??5.      $??13??6    $??0,0,0,0q?6,   
???  ????5/      ?? 50      $
 /View/Untitled-2.png??6!   52      53      54      55      