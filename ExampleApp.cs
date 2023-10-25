using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
 
public class ExampleApp : App
{
    public ExampleApp(
        Game game,
        List<Card> tier1,
        List<Card> tier2,
        List<Card> tier3,
        List<Card> tier4,
        List<Card> tier5,
        List<Card> tier6)
    {
        this.Game = game;
        this.Tier1 = tier1;
        this.Tier2 = tier2;
        this.Tier3 = tier3;
        this.Tier4 = tier4;
        this.Tier5 = tier5;
        this.Tier6 = tier6;

        this.Game.availableCards.AddCards(Tier1);
        this.Game.RefreshPlayerStore();
        //this.SetStoreCards();
        //SetStoreCards(this.Game.RefreshPlayerStore());
    }
    public List<Card> Tier1 = null;
    public List<Card> Tier2 = null;
    public List<Card> Tier3 = null;
    public List<Card> Tier4 = null;
    public List<Card> Tier5 = null;
    public List<Card> Tier6 = null;
    // bool fundiu = false;
    Card selected = null;
    bool clicked = false;
    bool wasClicked = false;
    public Game Game { get; set; }
    RectangleF deck = new RectangleF(50, 600, 1000, 200);
    RectangleF joia = new RectangleF(1200, 800, 400, 400);
    // RectangleF rect1 = RectangleF.Empty;
    // RectangleF rect2 = RectangleF.Empty;

    public void SetStoreCards()
    {
        this.Store = new();

        for (int i = 0; i < this.Game.player.Store.Cards.Count(); i++)
        {
            var card = this.Game.player.Store.Cards[i];
            if(card is not null)
                Store.Add(
                    DrawPiece(
                        new RectangleF(200 * (i + 1), 50, 200, 200),
                        card.Attack,
                        card.Life,
                        card.Experience,
                        card.Tier,
                        true,
                        card.Name));
        }
    }

    List<RectangleF> Store = new();

    public override void OnFrame(bool isDown, PointF cursor)
    {
        DrawImage(new Bitmap(Image.FromFile("./imgs/deck.png")), deck);

        for (int i = 0; i < this.Store.Count(); i++)
            if (this.Store[i].Contains(cursor) && !isDown && selected is null)
                selected = this.Game.player.Store.Cards[i];


        // Desenha Loja
        for (int i = 0; i < this.Game.player.Store.Cards.Count(); i++)
        {
            var card = this.Game.player.Store.Cards[i];
            if (card is not null)
            DrawPiece(
                new RectangleF(200 * (i + 1), 50, 200, 200),
                card.Attack,
                card.Life,
                card.Experience,
                card.Tier,
                true,
                card.Name);
        }

        // Atualiza Loja
        clicked = DrawButton(new RectangleF(1000, 50, 200, 100), "Refresh");
        if (clicked && !wasClicked)
        {
            wasClicked = true;
            this.Game.RefreshPlayerStore();
            this.SetStoreCards();
        }
        if (!clicked)
            wasClicked = false;

        
        if(isDown)
            DrawImage(new Bitmap(Image.FromFile("./imgs/joia.jpg")), joia);


        for (int i = 0; i < this.Store.Count(); i++)
            if (this.Store[i].Contains(cursor) && !isDown)
                DrawImage(new Bitmap(Image.FromFile("./imgs/joia.jpg")), joia);

        for (int i = 0; i < this.Store.Count(); i++)
        {
            var cardG = this.Store[i];
            
            if (deck.Contains(cursor) && isDown)
            {
                //DrawImage(new Bitmap(Image.FromFile("./imgs/joia.jpg")), new RectangleF(200 * (i + 1), 50, 200, 200));

                this.Game.player.Store.Cards[i] = null;
                this.Store.Remove(cardG);
            }
        }
        

        //if (rect1.Contains(cursor) && rect2.Contains(cursor) && !isDown)
        //    fundiu = true;

        
        

        /*
 
        if (!fundiu)
        {
            rect1 = DrawPiece(new RectangleF(50, 50, 200, 200), 1, 3, 1, 1, true, "CNC");
            rect2 = DrawPiece(new RectangleF(300, 50, 200, 200), 2, 4, 2, 1, true, "CNC");
        }
        else
        {
            DrawPiece(new RectangleF(50, 50, 200, 200), 3, 5, 3, 1, true, "CNC");
        }
 

        */
    }
}