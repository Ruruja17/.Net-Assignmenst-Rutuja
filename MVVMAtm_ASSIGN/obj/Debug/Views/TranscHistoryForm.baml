   M S B A M L   `   `   `  ????I  EMVVMAtm_ASSIGN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MVVMAtm_ASSIGN.ViewsMVVMAtm_ASSIGN.Views  5   	   E'clr-namespace:MVVMAtm_ASSIGN.ViewModelsMVVMAtm_ASSIGN.ViewModels  5   	   ,    &MVVMAtm_ASSIGN.Views.TranscHistoryForm   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:MVVMAtm_ASSIGN.Views     5   	   6vm'clr-namespace:MVVMAtm_ASSIGN.ViewModels     5   	     ? Title$  TranscHistoryForm??5	   	   $	??450??6#   $	??800??60    ? 	Resources 5
      ,   &MVVMAtm_ASSIGN.ViewModels.AtmViewModel   atmvmObj??%   &	          5   
   6   5      .??5      ?  ? DataContext# [  6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   6-   ?? 5      $
??auto ?6   6-   ?? 5      $
??auto ?6   6-   ?? 5      $
??auto ?6   6-   .+?5   
   ? $??0??6   .+?5      ?? $??Welcome To ATM SERVICES??6   $??60)?66   $??40(?6F   
???????
???   ?6h   5      ? 5   
   $??1??6    ? ColumnDefinitions 5      ?? 5      $
??auto ?6#   62   ?? 5      $
??auto ?6#   62   .+?5      ?? $??Enter Your PIN??6   $??20)?6/   $??20(?6?   
???????
???????6a   ?? 5       -   5        $??
txtUserPIN??5    3   $??1??6   $??1??6#   ??6F   ?? *UI_Pin+ ?? UpdateSourceTrigger$ PropertyChanged=?5"      ?? 5#   
    ?? Orientation$ 
Horizontal=?6   $??2??6.   $??Center=?6;   $??Center=?6X   .+?5$      ?? -   5        $??btnCheckTranscHistory??5$   4   $?? Transaction History??6   $??18(?6Q   $??20)?6_   $??Italic$?6o   
???????
???   ???6?   ?? *CheckTranscHistoryCommand+5(      &   System.Windows.Controls.DataGrid  5)   
   -   5        $??transcDataGrid??5)   <   $??3??6      AutoGenerateColumns . $	??300??6R   ??6_   ?? *
CardList+6?   5*      5,      