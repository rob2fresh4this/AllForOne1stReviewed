
namespace AllForOne.Service
{
    public class RestaurantPickerService
    {
        public string RestaurantPicked;
        public RestaurantPickerService()
        {
            RestaurantPicked = "Error: No restaurant picked";
        }

        public string PickedRestaurant(string categoryMexicanChineseJapanese)
        {
            categoryMexicanChineseJapanese = categoryMexicanChineseJapanese.ToLower();
            string[] mexican = {
                "La Casa de Sabor - The House of Flavor",
                "El Sombrero Cantina - The Hat Bar",
                "Mi Tierra Taquería - My Land Taco Shop",
                "Cielo Azul Cocina - Blue Sky Kitchen",
                "Los Tres Amigos - The Three Friends",
                "Taco Loco Grill - Crazy Taco Grill",
                "Agave y Limón - Agave and Lime",
                "El Charro de Oro - The Golden Cowboy",
                "Fuego y Salsa - Fire and Salsa",
                "Pueblo Bonito Cocina Mexicana - Beautiful Village Mexican Kitchen"
            };

            string[] chinese = {
                "Golden Dragon Palace",
                "Lotus Blossom Garden",
                "Jade Emperor Kitchen",
                "Red Lantern Bistro",
                "Bamboo Forest NoodlesText",
                "Imperial Wok House",
                "Panda Blossom Diner",
                "Moon Gate Dim Sum",
                "Dragon Pearl Cuisine",
                "Silk Road Café"
            };

            string[] japanese = {
                "Sakura Blossom Bistro",
                "Zen Garden Sushi",
                "Tokyo Bay Grill",
                "Koi Pond Ramen",
                "Hana Teppanyaki House",
                "Nori & Rice Sushi Bar",
                "Mount Fuji Bistro",
                "Samurai Noodle House",
                "Izakaya Sake Lounge",
                "Shogun Teppan Grill"
            };

            if (categoryMexicanChineseJapanese == "mexican")
            {
                Random random = new Random();
                int index = random.Next(0, mexican.Length);
                RestaurantPicked = mexican[index];
            }
            else if (categoryMexicanChineseJapanese == "chinese")
            {
                Random random = new Random();
                int index = random.Next(0, chinese.Length);
                RestaurantPicked = chinese[index];
            }
            else if (categoryMexicanChineseJapanese == "japanese")
            {
                Random random = new Random();
                int index = random.Next(0, japanese.Length);
                RestaurantPicked = japanese[index];
            }

            return RestaurantPicked;
        }
    }
}