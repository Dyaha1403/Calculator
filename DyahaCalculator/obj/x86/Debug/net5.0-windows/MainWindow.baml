   M S B A M L   `   `   `  ����J  FDyahaCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DyahaCalculatorDyahaCalculator  5   	        DyahaCalculator.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:DyahaCalculator     5   	   -   5          �Name$  CalculatorWindow��5   	   
���   � � Title$ 
Calculator��5
   	   $	��395��6   $	��250��6)    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	    � Icon$ Pictures\calculator.png��5   	   .��5      � -   5         �Name$ MainRoot��5      $	��500��6    � RowDefinitions 5   
   �� 5      $��29 �6   �� 5      $��32 �6   �� 5      $��64 �6   �� 5      $��20 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��20 �6   �� 5      $��25 �6   �� 5       $��30 �6   �� 5!      $��30 �6    � ColumnDefinitions 5$   
   �� 5%      $��50 �6   �� 5&      $��50 �6   �� 5'      $��50 �6   �� 5(      $��50 �6   �� 5)      $��50 �6   .+�5.   
   �� $��0��6   ���#141414$��5��67   .+�5/      �� -   5        	 ��Name$	 ButtonClose��5/         ButtonCloseStyle#��[  50      
������ 
�������$
��Bold"�53      $��Right=�54      $��30��55      $��30��56      $��0q�57      .��58      �� $	��✕��6   $��30��59      $��30��5:      
 �� TextAlignment$
 Center=�5;      $��15(�5<       �� Padding$ 
0, 4, 2, 0q�5=      5>      5?      �� 5A   
   $��Pictures\calculator.png��6   $
��Left=�61   $��29��6L   �� 5C   
   $��Калькулятор��6   $��3��5D      
�������$��Arial)�5F      $
��Left=�5G      $��32,2,0,0q�6+   $��83��6=   �� 5K   
   -   5         ��Name$ 
ResultText��5K      $��20(�5L      $��1��5M      $��Right=�5N      
������� J� Opacity$	 0.8Q�5P      $��5��6   �� 5R   
   -   5         ��Name$ InputBox��5R      $��2��6$   $��5��5S       �� 
IsReadOnly$
 True��5T      $��30(�5U      
���   �
�������$��0q�5X       �� TextWrapping$
 Wrap=�5Y       �� TextAlignment$ Right=�5Z      $��0,10,0,0q�5[      �� 5]   
   $��3��6   ���#141414$��5��5^   #   $��0,9,0,9q�5_      �� 5a   
   -   5        $��2��5a      $��4��6!   $��R��5b        ButtonStyle#��[ 5c      5f      � 5h   
   -   5        $ 
ButtonGrid��5h      $��4��6#   $��5��60   $��5��5j       5l      �� 5m      $��50 �6    �� 5n      $��50 �6    �� 5o      $��50 �6    �� 5p      $��50 �6    �� 5q      $��50 �6     5t      �� 5u      $��50 �6#   �� 5v      $��50 �6#   �� 5w      $��50 �6#   �� 5x      $��50 �6#   �� 5y      $��50 �6#   .+�5~      �� -   5        $��0��5~      $��0��6%   $��C��5      #��[ 5�      5�      �� 5�      -	   5        $��1��5�      $��0��6%   $	��⌫��5�      #��[ 5�      5�      �� 5�      -
   5        $��0��5�      $��1��6%   $��1��5�      #��[ 5�      5�      �� 5�      -   5        $��1��5�      $��1��6%   $��2��5�      #��[ 5�      5�      �� 5�      -   5        $��2��5�      $��1��6%   $��3��5�      #��[ 5�      5�      �� 5�      -   5        $��0��5�      $��2��6%   $��4��5�      #��[ 5�      5�      �� 5�      -   5        $��1��5�      $��2��6%   $��5��5�      #��[ 5�      5�      �� 5�      -   5        $��2��5�      $��2��6%   $��6��5�      #��[ 5�      5�      �� 5�      -   5        $��0��5�      $��3��6%   $��7��5�      #��[ 5�      5�      �� 5�      -   5        $��1��5�      $��3��6%   $��8��5�      #��[ 5�      5�      �� 5�      -   5        $��2��5�      $��3��6%   $��9��5�      #��[ 5�      5�      �� 5�      -   5        $��1��5�      $��4��6%   $��0��5�      #��[ 5�      5�      �� 5�      -   5        $	 ButtonChangeSign��5�      $��0��6/   $��4��6?   $	��+/-��5�      #��[ 5�      5�      �� 5�      -   5        $��2��5�      $��4��6%   $��=��5�      #��[ 5�      5�      � 5�      -   5        $ ButtonOperationGrid��5�      $��0��60   $��3��6=   $��2��5�      $��5��6'    5�      �� 5�      $��50 �6$   �� 5�      $��50 �6$   �� 5�      $��50 �6$   �� 5�      $��50 �6$   �� 5�      $��50 �6$    5�      �� 5�      $��50 �6'   �� 5�      $��50 �6'   .+�5�      �� -   5        $��0��5�      $��2��6)   $��0��6=   $
��√x��5�      #��[ 5�      5�      �� 5�      -   5        $��0��5�      $��2��6)   $��1��6=   $��sin(x)��5�      #��[ 5�      5�      �� 5�      -   5        $��0��5�      $��2��6)   $��2��6=   $	��x*x��5�      #��[ 5�      5�      �� 5�      -   5        $��0��5�      $��3��6)   $��/��5      #��[ 5     5     �� 5     -   5        $��3��5     $��4��6)   $��*��5     #��[ 5     5
     �� 5     -   5        $��4��5     $��3��6)   $��+��5     #��[ 5     5     �� 5     -   5        $��0��5     $��4��6)   $��-��5     #��[ 5     5     5     5     �� 5  
   $��9��6   ���#141414$��5��5  #   $��0,9,0,9q�5     �� 5  
   $!��Первая граница��6   $��10��5     $��2��5      
�������$��11(�5"     $��Center=�5#     $��Center=�5$     �� 5&  
   $!��Вторая граница��6   $��10��5'     $��3��5(     $��2��5)     
�������$��11(�5+     $��Center=�5,     $��Center=�5-     �� 5/  
   -   5        $ TextBoxFirstLimit��5/     $��11��6-   $��2��50     ���#212121
������ 
�������$��20(�54     55     �� 57  
   -   5        $ TextBoxSecondLimit��57     $��11��6.   $��3��58     $��2��59     ���#212121
������ 
�������$��20(�5=     5>     5?     5@     