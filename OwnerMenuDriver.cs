using System;

public class OwnerMenuDriver
{
    bool CurrentMenu;

    public OwnerMenuDriver()
	{
        CurrentMenu = true;
	}

    public bool RunMenu()
    {
        bool exit = false;
        OwnerMenu om = new OwnerMenu();

        while (CurrentMenu)
        {
            int input = om.GetMenuItem();

            switch (input)
            {
                case 1:
                    DisplayAllStockRequests sr = new DisplayAllStockRequests();
                    sr.ProcessRequests();
                    break;
                case 2:
                    DisplayStockRequests dsr = new DisplayStockRequests();
                    dsr.ProcessRequests();
                    break;
                case 3:
                    DisplayProductLines dpl = new DisplayProductLines();
                    dpl.ProcessRequests();
                    break;
                case 4:
                    CurrentMenu = false;
                    break;
                case 5:
                    CurrentMenu = false;
                    exit = true;
                    break;
            }
        }
        return exit;
    }
}
