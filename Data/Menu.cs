using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {

        public static IEnumerable<IOrderItem> Entrees()
        {
            List<Entree> returnValue = new List<Entree>();
            returnValue.Add(new AngryChicken());
            returnValue.Add(new CowpokeChili());
            returnValue.Add(new PecosPulledPork());
            returnValue.Add(new RustlersRibs());
            returnValue.Add(new TrailBurger());
            returnValue.Add(new DakotaDoubleBurger());
            returnValue.Add(new TexasTripleBurger());

            return returnValue;
        }
        public static IEnumerable<IOrderItem> Sides()
        {
            List<Side> returnValue = new List<Side>();
            returnValue.Add(new BakedBeans());
            returnValue.Add(new ChiliCheeseFries());
            returnValue.Add(new CornDodgers());
            returnValue.Add(new PanDeCampo());

            return returnValue;
        }
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<Drink> returnValue = new List<Drink>();
            returnValue.Add(new JerkedSoda());
            returnValue.Add(new CowboyCoffee());
            returnValue.Add(new TexasTea());
            returnValue.Add(new Water());
            return returnValue;
        }

        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> returnValue = new List<IOrderItem>();
            returnValue.Add(new AngryChicken());
            returnValue.Add(new CowpokeChili());
            returnValue.Add(new PecosPulledPork());
            returnValue.Add(new RustlersRibs());
            returnValue.Add(new TrailBurger());
            returnValue.Add(new DakotaDoubleBurger());
            returnValue.Add(new TexasTripleBurger());
            returnValue.Add(new BakedBeans());
            returnValue.Add(new ChiliCheeseFries());
            returnValue.Add(new CornDodgers());
            returnValue.Add(new PanDeCampo());
            returnValue.Add(new JerkedSoda());
            returnValue.Add(new CowboyCoffee());
            returnValue.Add(new TexasTea());
            returnValue.Add(new Water());

            return returnValue;
        }









    }
}
    