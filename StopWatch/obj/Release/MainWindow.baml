   M S B A M L   `   `   `  ���� D  @StopWatch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:StopWatch	StopWatch      StopWatch.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     )localclr-namespace:StopWatch     -     � Icon$  1444852984_timer.ico��$	��115��$	��366�� � AllowsTransparency .  � WindowStyle$
 None=�.���� $��3q����	#FF39393D._�� ���	#FF2D2D30 � RowDefinitions �� �� $��0* �.+��� -    ��Name$ tb_time��$
��Wrap=�$��00:00:00��$��117,24,0,36q�$	��142��$��35(�$
��Left=����	#FF2D2D30
��������� $��18,83,162,6q�._�� .+�   StopWatch.NumberUp  -     Name$ nu_hour��$
��Left=�$��20��$	��Top=�$��31��$��
-11,1,0,-1q��� $
��Left=�$��20��$��	23,1,0,-1q�$
��Wrap=�$	��Top=�$��34��$��시간��
�������  -   $ nu_min��$
��Left=�$��20��$��57,0,0,0q�$	��Top=�$��31���� $
��Left=�$��20��$��91,0,0,0q�$
��Wrap=�$
��분 ��$	��Top=�$��22��
��������� $
��Left=�$��20��$��	153,0,0,0q�$
��Wrap=�$
��초 ��$	��Top=�$��22��
�������  -   $ nu_sec��$
��Left=�$��20��$��	116,0,0,0q�$	��Top=�$��31���� -    ��Name$ bt_add��$	��Set��$
��Left=�$	��Top=�$��75��$��
203,82,0,0q�
����������	#FF2D2D30
�������$��Microsoft Tai Le)��� -    ��Name$ rt_bar�����	#FF39393D$
��Left=�$��22��$	��Top=�$	��362���� -   $ 
tb_bartext��$
��Left=�$
��Wrap=�$��Null StopWatch��$	��Top=�$��	137,3,0,0q�
��������� -	   $ rt_Exit��
�������$
��Left=�$��17��$��	340,2,0,0q����	#FF2D2D30$	��Top=�$��17���� -
    ��Name$ cb_top��$��	최상위��$
��Left=�$	��Top=�$��
290,83,0,0q����	#FF5B5B5B
�������