   M S B A M L   `   `   `  ����H  DclassProgram1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:classProgram1classProgram1  5   	       classProgram1.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:classProgram1     5   	     � Title$  
MainWindow��5   	   $	��700��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Center=�6   $��0,34,0,0q�61   $
��Wrap=�6C   $��Libreria��6W   $	��Top=�6g   $��41��6   $	��200��6�   $��30(�6�    �� TextAlignment$ Center=�6�   ���	#FF00D4CF6�   �� 5   
   -   5         ��Name$ numTxt��5      $��Center=�6"   $��	0,101,0,0q�6?    �� TextWrapping$
 Wrap=�6R   $�� ��6f   $	��Top=�6n   $	��200��6�   $��30��6�   �� 5   
   $
��Left=�6   $��
62,101,0,0q�6/   $
��Wrap=�6C   $��Numero de telefono��6W   $	��Top=�6q   $��30��6�   $	��200��6�   $��20(�6�   $ Center=�6�   ���	#FF00D4CF6�   �� 5   
   -   5         ��Name$ enterCallBtn��5      $��Ingresar llamada��6'   $
��Left=�6B   $��538,101,0,0q�6]   $	��Top=�6r   $	��200��6�   $��30                 ��6�   ���	#FF00D4CF5   *   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ pendingGrid��5      $��143,177,162,134q�6(   �� 5   
   -   5        $ receiveCallBtn��5      $��Atender llamada��6)   $
��Left=�6C   $��
62,589,0,0q�6^   $	��Top=�6r   $	��268��6�   $��53��6�   ���	#FF00D4CF6�   �� 5   
   -   5        $ viewCallsBtn��5      $��Ver llamadas finalizadas��6'   $
��Left=�6J   $��470,589,0,0q�6e   $	��Top=�6z   $	��268��6�   $��53��6�   ���	#FF00D4CF6�   5      5      