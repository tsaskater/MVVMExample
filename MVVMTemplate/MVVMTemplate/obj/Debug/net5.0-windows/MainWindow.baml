   M S B A M L   `   `   `  ����G  CMVVMTemplate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MVVMTemplateMVVMTemplate  5   	   1clr-namespace:MVVMTemplate.VMMVVMTemplate.VM  5   	   1clr-namespace:MVVMTemplate.UIMVVMTemplate.UI  5   	       MVVMTemplate.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MVVMTemplate     5   	   ,vmclr-namespace:MVVMTemplate.VM     5   	   ,uiclr-namespace:MVVMTemplate.UI     5   	     � Title$  
MainWindow��5
   	   $	��450��5   	   $	��800��6    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   ���	#FFCBCBCB � 	Resources 5      &   MVVMTemplate.VM.ExampleViewModel   VM,  &MVVMTemplate.UI.ResultToBrushConverter  ResultToBrushConverter��%:   &	        &	        5   
   6     5   
   6$   5      .��5      �  � DataContext# [  6   .+�5   
   �� $��
Number 1: ��6   $
��Left=�6%   $��	72,97,0,0q�6@   $	��Top=�6S   $��24(�6k   �� 5   
   $��
Number 2: ��6   $
��Left=�6%   $��
72,191,0,0q�6@   $	��Top=�6T   $��24(�6l   �� 5   
   $��Add Numbers��65   $
��Left=�6K   $��522,322,0,0q�5      $	��Top=�6&   $	��206��6>   $��60��6J   $��24(�6V   ��5      ��  �� Path$ 
AddNumbers�5   V   �� 5   
   $��Don't click this��68   $
��Left=�6S   $��
665,25,0,0q�5      $	��Top=�6%   $	��100��6=   $��30��6I   $��11(�6U   ���	#FFB0B0B0��5      �� $ DontClickThis���5   c   Z� ��6y   Z� 6�   �� 5   
   $
��Left=�61   $��220,101,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��447��6�   $��24(�6�    �� 	MaxLength$ 5��6�   ��6   �� $ Number1�6�   �� 5   
   $
��Left=�60   $��220,195,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��448��6�   $��24(�6�   $ 5��6�   ��6   �� $ Number2�6�   �� 5   
   $��Result: ��6   $
��Left=�6#   $��
72,301,0,0q�6>   $	��Top=�6R   $��24(�6j   �� 5   
   $
��Left=�60   $��220,301,0,0q�6K   $	��Top=�6`   $	��224��6x   $��24(�6�   ��6   �� $ Result���6�   �� $ Result� �� 	Converter# [ 5      5       