   M S B A M L   `   `   `  ????I  EMVVMAtm_ASSIGN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MVVMAtm_ASSIGN.ViewsMVVMAtm_ASSIGN.Views  5   	   E'clr-namespace:MVVMAtm_ASSIGN.ViewModelsMVVMAtm_ASSIGN.ViewModels  5   	   $    MVVMAtm_ASSIGN.Views.LoginForm   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:MVVMAtm_ASSIGN.Views     5   	   6vm'clr-namespace:MVVMAtm_ASSIGN.ViewModels     5   	     ? Title$  	LoginForm??5	   	   $	??450??6   $	??800??6(    ? WindowState$ 	Maximized=?64    ? 	Resources 5      ,   &MVVMAtm_ASSIGN.ViewModels.AtmViewModel   atmvmObj??%   &	          5   
   6   5      .??5      ?  ? DataContext# [  6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   6-   ?? 5      $
??auto ?6   6-   ?? 5      $
??auto ?6   6-   .+?5   
   ?? $?? WELCOME TO ATM SERVICES??6   $??Arial Black)?64   $??20(?6M   
??? ???
???   ?$??Center=?6?   $??Center=?6?   ? 5   
   $??1??6   $??Center=?6   $??Center=?69    5      ?? 5      $
??auto ?6    61   ?? 5      $
??auto ?6    61    ? ColumnDefinitions 5      ?? 5      $
??auto ?6#   62   ?? 5      $
??auto ?6#   62   .+?5       ?? $??Card No??6   $??0??6&   $??20)?63   
???????$??Italic$?6W   
???   ?6j   ?? 5!      $??Enter Your Pin??6   $??1??6-   $??20)?6:   
???????$??Italic$?6^   
???   ?6q   ?? 5#      -   5        $??	txtUserId??5#   3   $??0??6   $??1??6#   ??6D   ?? *	UI_CardNo+ ?? UpdateSourceTrigger$ PropertyChanged=??? 5$      -   5        $??
txtUserPIN??5$   3   $??1??6   $??1??6#   ??6F   ?? *UI_Pin+$ PropertyChanged=?5*      ?? 5,   
    ?? Orientation$ 
Horizontal=?6   $??2??6.   $??Center=?6;   $??Center=?6X   .+?5-      ?? -   5        $??btnLogin??5-   %   $??Login??6   $??18(?65   $??20)?6C   $??Italic$?6S   
???????
???   ???6?   ?? *ValidCommand+5/      51      52      