   M S B A M L   `   `   `  ����E  AITI_System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ITI_System.Management.FormsITI_System.Management.Forms  5   	   *    $ITI_System.Management.Forms.FrmLogIN   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:ITI_System.Management.Forms     5   	   -   5          � Title$  FrmLogIN��5   	   $��407.405��6   $��655.821��6+   .��5	      � 
��� � �$
��Left=�6   $	��646��69    � RowDefinitions 5
   
   �� 5      $
��169* �6   �� 5      $
��207* �6   .+�5   
   �� -   5         ��Name$ image1��5      $
��Left=�6    $	��118��6;   $	��Top=�6H   $	��641��6`   $��	10,10,0,0q�6m   �� 5   
   -   5        $ image2��5      $!��Management\PIC\ITI logo.png��6    $
��Left=�6E   $	��118��6`   $	��Top=�6m   $	��641��6�   $��	10,10,0,0q�6�   �� 5   
   -   5         ��Name$ lbluserName��5   ]   $	��143��6   $��50��6   
�������$��25(�6=   $
��Bold"�6K   $��	User Name��6r   $
��Left=�6�   $��
27,162,0,0q�6�   $	��Top=�6�   $��2��6�   �� 5   
   -   5        $ 
lblPasword��5   ]   $	��120��6   $��50��6   
�������$��25(�6=   $
��Bold"�6K   $��Password��6q   $
��Left=�6�   $��28,57.198,0,0q�6�   $	��Top=�6�   $��1��6�   �� 5   
   -   5         ��Name$ txtUserName��5   S   $��admin��6   
��� � �$��25(�63   $
��Bold"�6A   $
��Left=�6h   $��39��6�   $��186,167,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��374��6�   $��2��6�   G� 5   
   -   5         G�Name$ txtpasswordBox��5   [    G� Password$ admin��6   
��� � �$��25(�6;   $
��Bold"�6I   $
��Left=�6s   $��186,65.198,0,0q�6�   $	��Top=�6�   $	��374��6�   $��38��6�   $��1��6�   �� 5   
   -   5         ��Name$ button52��5      $
��Left=�6#   $��359,139,0,25q�6>   $��1��6T   $	��120��6a   .��5      �� -	   5        $. (____ITI_System_component_Apply_32x32_png��5      $$��Management\PIC\Apply_32x32.png��6F   $��32��6n   $
��Fill=�6{   $��54��6�   5      �� 5   
   -
   5        $ button_Copy��5      $
��Left=�6&   $��196,139,0,0q�6A   $��1��6V   $	��Top=�6c   $	��120��6{   $��43��6�   .��5      �� -   5        $+ %___ITI_System_component_Cancel_64_png��5      $��33��6C   $"��Management\PIC\Cancel-64.png��6O   $
��Fill=�6u   $��64��6�   5      �� 5   
   -   5        $ button��5      $
��Left=�6!   $��560,152,0,0q�6<   $��1��6Q   $	��Top=�6^   $��75��6v   .��5      �� -   5        $ btnAddInsCrsLab��5      $��Button��6.   $��75��6?   6J   5       5"      5#      