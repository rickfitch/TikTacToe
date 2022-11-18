using static TicTacPlayGrid;

public class Program    
{
    public static void Main(string[] args)
    {
        int player = 2;
        int input = 0;
        bool inputCorrect = true;

        TicTacPlayGrid.PlayGrid();
             

        do
        {
            if(player == 2)
                player = 1;
            else if(player == 1)
                player = 2;

            input = Convert.ToInt32(Console.ReadLine());

            switch (player)
            {
                case 1: //Player 1 turn
                    {
                        switch (input)
                        {
                            case 1: playfield[0, 0] = 'x'; break;
                            case 2: playfield[0, 1] = 'x'; break;
                            case 3: playfield[0, 2] = 'x'; break;
                            case 4: playfield[1, 0] = 'x'; break;
                            case 5: playfield[1, 1] = 'x'; break;
                            case 6: playfield[1, 2] = 'x'; break;
                            case 7: playfield[2, 0] = 'x'; break;
                            case 8: playfield[2, 1] = 'x'; break;
                            case 9: playfield[2, 2] = 'x'; break;
                        }
                        break;

                    }
                case 2: //Player 2 turn
                    {
                        switch (input)
                        {
                            case 1: playfield[0, 0] = 'o'; break;
                            case 2: playfield[0, 1] = 'o'; break;
                            case 3: playfield[0, 2] = 'o'; break;
                            case 4: playfield[1, 0] = 'o'; break;
                            case 5: playfield[1, 1] = 'o'; break;
                            case 6: playfield[1, 2] = 'o'; break;
                            case 7: playfield[2, 0] = 'o'; break;
                            case 8: playfield[2, 1] = 'o'; break;
                            case 9: playfield[2, 2] = 'o'; break;
                        }
                        break;
                    }
            }
            PlayGrid();
        }while(true);


    






    }
}