   M S B A M L   `   `   `  ����L  HNotePad In CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:NotePad_In_CSharpNotePad_In_CSharp  5   	   "    NotePad_In_CSharp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:NotePad_In_CSharp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��1* �6   �� 5      $��20 �6   .+�5   
   o� $��0��6   .@�5      m� $
��File��6   $��30��6%   $��50��61   $
��15 0q�6<   
�������$	��1 0q�6b   .@�5      m� -   5         m�Name$	 New��5      $	��New��6(    m� InputGestureText$ CTRL + N��65   6R   m� 5      -   5        $
 Open��5      $
��Open��6)   $ CTRL + O��67   6S   m� 5      -   5        $
 Save��5      $
��Save��6)   $ CTRL + S��67   6S   �� 5      m� 5      -   5        $ Close��5      $��Close��6*   69   5      5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $	��70* �6#   �� 5      $	��30* �6#   .+�5      �� -   5         ��Name$ FileName��5      $��16(�6(   $��0��66   $��Center=�6F   �� 5      -   5        $ FileExtention��5      $��16(�6-   $��1��6;   $��Center=�6K   5       �� 5!   
   -   5         ��Name$ TextArea��5!      $��2��6)   $��16(�66   $��5q�6D   6R   �� 5"   
   -   5         ��Name$ 	WordCount��5"      $��3��6'   $��14(�64   6D   5#      5$      