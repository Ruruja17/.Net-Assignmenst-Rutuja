   M S B A M L   `   `   `  ????I  EMVVMAtm_ASSIGN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MVVMAtm_ASSIGN.ViewsMVVMAtm_ASSIGN.Views  5   	   E'clr-namespace:MVVMAtm_ASSIGN.ViewModelsMVVMAtm_ASSIGN.ViewModels  5      .    (MVVMAtm_ASSIGN.Views.TransactionModeForm   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:MVVMAtm_ASSIGN.Views     5   	   6vm'clr-namespace:MVVMAtm_ASSIGN.ViewModels     5        ? Title$  TransactionModeForm??5	   	   $	??450??6%   $	??800??62    ? 	Resources 5
      ,   &MVVMAtm_ASSIGN.ViewModels.AtmViewModel   atmvmObj??%   &	          5   
   6   5      .??5      ?  ? DataContext# [  6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   6-   ?? 5      $
??auto ?6   6-   ?? 5      $
??auto ?6   6-   .+?5   
   ? $??0??6   .+?5      ?? $"??Select Your Transaction Mode??6   $??60)?6;   $??30(?6K   
???????
???   ?6m   5      ?? 5   
    ?? Orientation$ 
Horizontal=?6   $??1??6.   $??Center=?6;   $??Center=?6X   .+?5      ?? -   5        $??btnCheckBalance??5   -   $??Check Balance??6   $??18(?6D   $??20)?6R   $??Italic$?6b   
???????
???   ???6?   ?? *BalanceCommand+5      ?? 5   
   $ 
Horizontal=?6   $??2??6.   $??Center=?6;   $??Center=?6X   .+?5      ?? -   5        $??btnTranscHistory??5   3   $??Transaction History??6   $??18(?6K   $??20)?6Y   $??Italic$?6i   
???????
???   ???6?   ?? *TtrnascHistoryCommand+5#      5$      5%      