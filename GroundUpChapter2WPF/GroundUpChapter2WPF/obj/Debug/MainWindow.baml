   M S B A M L   `   `   `  ����N  JGroundUpChapter2WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:GroundUpChapter2WPFGroundUpChapter2WPF  5   	   $    GroundUpChapter2WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:GroundUpChapter2WPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         BodyTextStyle �� 
TargetType �� Property �� Value��%P   &	        �� 5
   
   " ��6&   .�5      ��  � ��$  ��6%   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ button1��5      $��Show a message��6"   $��Center=�6;   $��Center=�6X   6s   �� 5   
   -   5        $ button2��5      $��If/Else��6"   $��1��64   $��Center=�6D   $��Center=�6a   6|   �� 5   
   -   5        $ button3��5      $��Another conditional test��6"   $��Center=�6E   $��1��6b   $��Center=�6o   6�   �� 5   
   -   5        $ button4��5      $��A loop��6"   $��1��63   $��Center=�6C   $��1��6`   $��Center=�6m   6�   �� 5   
   -   5         ��Name$ myLabel��5      $��Center=�6%   $��2��6B   $
��Wrap=�6O   $��Center=�6c   #��[  6~   5      5      