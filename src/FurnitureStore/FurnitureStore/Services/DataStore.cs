using FurnitureStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureStore.Services
{
    public static class DataStore
    {
        static DataStore()
        {
            Items = new List<Item>();
            Items.Add(new Item()
            {
                Name = "Mammut",
                Description = "The robust and lightweight MAMMUT series withstands the elements of weather and wild imaginative play. Perfect for the outdoors and easy to clean when it’s time to move indoors.",
                InStock = true,
                Category = "Chairs",
                Price = 17.50M,
                Variations = new List<Variation>()
                {
                    new Variation () { ColorHex="#0000FF", Image="mammut_blue" },
                    new Variation () { ColorHex="#ffC0CB", Image="mammut_pink" },
                    new Variation () { ColorHex="#FF0000", Image="mammut_red" },
                }
            });

            Items.Add(new Item()
            {
                Name = "Mammut2",
                Description = "The robust and lightweight MAMMUT series withstands the elements of weather and wild imaginative play. Perfect for the outdoors and easy to clean when it’s time to move indoors.",
                InStock = true,
                Category = "Chairs",
                Price = 17.50M,
                Variations = new List<Variation>()
                {
                    new Variation () { ColorHex="#ffC0CB", Image="mammut_pink" },
                    new Variation () { ColorHex="#0000FF", Image="mammut_blue" },
                    new Variation () { ColorHex="#FF0000", Image="mammut_red" },
                }
            });

            Items.Add(new Item()
            {
                Name = "Poang",
                Description = "Layer-glued bent birch frame gives comfortable resilience. The high back gives good support for your neck.",
                InStock = false,
                Price = 119.00M,
                Category = "Chairs",
                Variations = new List<Variation>()
                {
                    new Variation () { ColorHex="#FF0000", Image="poang_red" },
                    new Variation () { ColorHex="#E1C699", Image="poang_beige" },
                    new Variation () { ColorHex="#36454F", Image="poang_charcoal" },
                    new Variation () { ColorHex="#00FF00", Image="poang_green" },
                }
            });

        }

        public static List<Item> Items;

        public static List<Category> GetCategories()
        {
            var categories = new List<Category>()
            {
                new Category() {Name = "Chairs"},
                new Category() {Name = "Sofas"},
                new Category() {Name = "Tables"},
                new Category() {Name = "Lamps"},
            };
            return categories;
        }

        internal static IEnumerable<Item> GetItemsForCategory(string obj)
        {
            return Items.Where(n => n.Category == obj);
        }

        internal static IEnumerable<Item> GetItemsForCategory(Category selectedCategory)
        {
            var selectedItems = new List<Item>();
            foreach (var item in Items)
            {
                selectedItems.Add(item);
            }

            return selectedItems;
        }
    }

}
