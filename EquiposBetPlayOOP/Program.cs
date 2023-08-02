using System;
using EquiposBetPlayOOP.View;

internal class Program
{
    private static void Main(string[] args)
    {
        MainMenu menu = new MainMenu();
        int option;
        do {
            option = menu.menu();

            switch(option){
                case 1:
                    MenuPlantel menuPlantel = new MenuPlantel();
                    int opcionPlantel;
                    do
                    {
                        opcionPlantel = menuPlantel.menuPlantel();
                    }while(opcionPlantel != 6);
                    break;
                case 2:
                    int optionSearch;
                    MenuBusqueda menuBusqueda = new MenuBusqueda();
                    do{
                        optionSearch = menuBusqueda.menuBusqueda();
                    }while(optionSearch != 4);
                    break;
                case 3:
                    break;
                default:
                    break;               
            } option = menu.menu();
        } while(option!=3);
    }
    
}

