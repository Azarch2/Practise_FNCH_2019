   M S B A M L   `   `   `  ????M  IInspectionPractice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:InspectionPracticeInspectionPractice  5   	   &     InspectionPractice.DriversWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:InspectionPractice     5   	     ? Title$8  2Окно управления водителями??5   	   $	??450??6,   $	??800??69   ???#b5d5ca ? WindowStartupLocation$ CenterScreen=?6Z    ? Icon$ Resources/gibdd_logo.png??6   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??75 ?6   6*   ?? 5      6   ?? 5      $??75 ?6   6*   .+?5   
   ?? 
???   ?$??2q?6%   ???#e0a9af6P   ?? 5   
   $??3??6   
???   ?$??2q?62   ???#e0a9af6]   ?? 5   
   $??Center=?6   $??Center=?61      TextBlockBig#??[  6L   $f??`В этом окне вы можете добавлять и изменять водителей??6r   $??26(?6?   6?   ?? 5   
   -   5        $??2??5   %   ???#fffcd6$
??Left=?6G   $??
Назад??6c   $??50??6s   $??Center=?6   $	??180??6?   $??10,0,0,0q?6?    ? 	Resources 5       ?? 
TargetType ?? Property ?? Value??%d   '??       ?? 5      " ??6   .?5      ??  ?@??CornerRadius$ 35??65   6B   5      5      5      ?? 5   
   -   5        $'??!Добавить водителя??5   (   $??10q?6E   $	??280??6Q   $??2??6]    5      ??%d   '??       ?? 5      " ??6   .?5      ??  ?@??CornerRadius$ 35??65   6B   5      5      5      &   System.Windows.Controls.DataGrid  5    
   -   5        $??GridOfDrivers??5    0      AutoGenerateColumns .  $??14(?6E   ???#fffcd6$??1??6h   $??5q?6u   	   Columns	 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ?? *Id+6J     5#      $

 Name??6%    63   ?? *Name+6N     5$      $
 
MiddleName??6%    69   ?? *
MiddleName+6Z     5%      $
 Surname??6%    66   ?? *	Surname+6T     5&      $
 PassportSerial??6%    6=   ?? *PassportSerial+6b     5'      $
 PassportNumber??6%    6=   ?? *PassportNumber+6b     5(      $
 Postcode??6%    67   ?? *
Postcode+6V     5)      $
 RegistrationAddress??6%    6B   ?? *RegistrationAddress+6l     5*      $
 ResidentialAddress??6%    6A   ?? *ResidentialAddress+6j     5+      $
 CompanyName??6%    6:   ?? *CompanyName+6\     5,      $
 JobTitle??6%    67   ?? *
JobTitle+6V     5-      $
 PhoneNumber??6%    6:   ?? *PhoneNumber+6\     5.      $
 Email??6%    64   ?? *Email+6P   4  .System.Windows.Controls.DataGridTemplateColumn  5/      $
 Photo??6)      CellTemplate 50      ?? 51      .R?52      ?? $??30??6$   $??3q?60   ??6;   ?? *Photo+6V   53      55        56         Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6%   $
 Description??61    6F   ?? *Description+6h     57      $
 Изменение??6)    58      ?? 59      .R?5:      ?? -   5        $??18(?5:   %   $??Изменить??6M   $??10q?6a   $??30??6m   $	??100??6y   $??2??6?    5;   "   ??%d   '??       ?? 5<   &   " ??6,   .?5=   *   ??  ?@??CornerRadius$ 20??6I   6V   5>   '   5?   #   5@      5A      5C      5E      ?? 5F   
   -   5        $??MyListVieTESTTEST??5F   4   $y?Hidden=?6   $??1??6'   ??5G      ?? 5H      .R?5I      ??  ?? Orientation$ Vertical=?6!   6:   5J      ??5L      ?? 5M      .R?5N      ?? $	??100??6   ??6*   ?? *Photo+6E   5O      5Q      5R      5S      