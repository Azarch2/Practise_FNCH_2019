   M S B A M L   `   `   `  ????M  IInspectionPractice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:InspectionPracticeInspectionPractice  5   	   &     InspectionPractice.LicenseWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:InspectionPractice     5   	     ? Title$  LicenseWindow??5   	   $	??450??6   $	??800??6,   ???#b5d5ca ? WindowStartupLocation$ CenterScreen=?6M    ? Icon$ Resources/gibdd_logo.png??6r    ? 
ResizeMode$ NoResize=?6?   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??75 ?6   6*   ?? 5      6   ?? 5      $??75 ?6   6*   .+?5   
   ?? 
???   ?$??2q?6%   ???#e0a9af6P   ?? 5   
   $??3??6   
???   ?$??2q?62   ???#e0a9af6]   ?? 5   
   $??Center=?6   $??Center=?61      TextBlockBig#??[  6L   $b??\В этом окне вы можете просматривать и добавлять ВУ??6r   $??26(?6?   6?   ?? 5   
   -   5        $??2??5   %   ???#fffcd6$
??Left=?6G   $??
Назад??6c   $??50??6s   $??Center=?6   $	??180??6?   $??10,0,0,0q?6?    ? 	Resources 5       ?? 
TargetType ?? Property ?? Value??%d   '??       ?? 5      " ??6   .?5      ??  ?@??CornerRadius$ 35??65   6B   5      5      5      ?? 5   
   -   5        $??Добавить ВУ??5   )   $??10q?6@   $	??280??6L   $??2??6X    5      ??%d   '??       ?? 5      " ??6   .?5      ??  ?@??CornerRadius$ 35??65   6B   5      5      5      &   System.Windows.Controls.DataGrid  5    
   -   5        $??GridOfLicenses??5    0   	   AutoGenerateColumns	 .  $??14(?6F   ???#fffcd6$??1??6i   $??5q?6v   
   Columns
 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ Id??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ?? *Id+6J     5#      $ LicenseDate??6%    6:   ?? *LicenseDate+6\     5$      $ 
ExpireDate??6%    69   ?? *
ExpireDate+6Z     5%      $ LicenseSeries??6%    6<   ?? *LicenseSeries+6`     5&      $ LicenseNumber??6%    6<   ?? *LicenseNumber+6`     5'      $ Driver??6%    5(      `? 5)       ?? StringFormat$ {0} {1} {2}??6'   .1?5*      ??  ?? Path$ Driver.Name?6&   6;   ?? 5+      $ Driver.Surname?6'   6?   ?? 5,      $ Driver.MiddleName?6'   6B   5-      5/        50      $ LicenseState??6%    6;   ?? *LicenseState.State+6d     51      $ LicenseState??6%    6;   ?? *allCategories+6_   53      54      55      