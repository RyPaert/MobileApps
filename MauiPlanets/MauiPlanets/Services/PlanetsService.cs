using Models;


namespace Services
{
    internal class PlanetsService
    {

        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods. Mercury is classified as a terrestrial planet, with roughly the same surface gravity as Mars. The surface of Mercury is heavily cratered, as a result of countless impact events that have accumulated over billions of years.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Mercury_in_true_color.jpg/290px-Mercury_in_true_color.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Unmasking_the_Secrets_of_Mercury.jpg/220px-Unmasking_the_Secrets_of_Mercury.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is a terrestrial planet and is the closest in mass and size to its orbital neighbour Earth. Venus has by far the densest atmosphere of the terrestrial planets, composed mostly of carbon dioxide with a thick, global sulfuric acid cloud cover. At the surface it has a mean temperature of 737 K (464 °C; 867 °F) and a pressure 92 times that of Earth's at sea level.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b2/Venus_2_Approach_Image.jpg/290px-Venus_2_Approach_Image.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/PIA00103_Venus_-_3-D_Perspective_View_of_Lavinia_Planitia.jpg/220px-PIA00103_Venus_-_3-D_Perspective_View_of_Lavinia_Planitia.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/5/54/Venus_-_December_23_2016.png/220px-Venus_-_December_23_2016.png",
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life exists. Almost 1.5 million species of animals and plants have been discovered so far, and many more have yet to be found. While other planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/The_Earth_seen_from_Apollo_17.jpg/290px-The_Earth_seen_from_Apollo_17.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/ISS-42_Waning_sun.jpg/220px-ISS-42_Waning_sun.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Mars_Hubble.jpg/250px-Mars_Hubble.jpg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the " +
                "largest in the Solar System. It is a gas giant with a mass more " +
                "than 2.5 times that of all the other planets in the Solar System " +
                "combined, and slightly less than one-thousandth the mass of the " +
                "Sun. Its diameter is eleven times that of Earth, and a tenth " +
                "that of the Sun. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Jupiter_and_its_shrunken_Great_Red_Spot.jpg/290px-Jupiter_and_its_shrunken_Great_Red_Spot.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/PIA21775.jpg/220px-PIA21775.jpg"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/Saturn_during_Equinox.jpg/300px-Saturn_during_Equinox.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/Saturn%2C_Earth_size_comparison.jpg/220px-Saturn%2C_Earth_size_comparison.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Saturn%27s_double_aurorae_%28captured_by_the_Hubble_Space_Telescope%29.jpg/200px-Saturn%27s_double_aurorae_%28captured_by_the_Hubble_Space_Telescope%29.jpg"
                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                            "It is named after Greek sky deity Uranus (Caelus), who in " +
                            "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                            "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                            "has the third-largest planetary radius and fourth-largest " +
                            "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/6/69/Uranus_Voyager2_color_calibrated.png/290px-Uranus_Voyager2_color_calibrated.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Uranus%2C_Earth_size_comparison_2.jpg/220px-Uranus%2C_Earth_size_comparison_2.jpg"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                            "the farthest known planet in the Solar System. It is the " +
                            "fourth-largest planet in the Solar System by diameter, the " +
                            "third-most-massive planet, and the densest giant planet. " +
                            "It is 17 times the mass of Earth, and slightly more " +
                            "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Neptune_Voyager2_color_calibrated.png/290px-Neptune_Voyager2_color_calibrated.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Neptune%2C_Earth_size_comparison_true_color.jpg/220px-Neptune%2C_Earth_size_comparison_true_color.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Neptune_storms.jpg/220px-Neptune_storms.jpg"
                }
            },
            new()
            {
                Name = "Makemake",
                Subtitle = "Makemake was named after the Rapanui god of fertility.",
                HeroImage = "makemake.png",
                Description = "Dwarf planet Makemake – along with Pluto, Haumea, and Eris – is located in the Kuiper Belt, a donut-shaped region of icy " +
                            "bodies beyond the orbit of Neptune. Makemake is slightly smaller than Pluto, " +
                            "and is the second-brightest object in the Kuiper Belt as seen from Earth while Pluto is the brightest. " +
                            "It takes about 305 Earth years for this dwarf planet to make one trip around the Sun.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/2/29/Makemake_and_its_moon.jpg"
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "Eris is one of largest the dwarf planets in our solar system. It's about the same size as Pluto, but it's three times farther from the Sun.",
                HeroImage = "eris.png",
                Description = "The discovery of Eris help trigger a debate in the scientific community that led to the International Astronomical Union's decision in 2006 to clarify the definition of a planet. Pluto, Eris, and other similar objects are now classified as dwarf planets.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1f/Hubble_Dysnomia_orbit_overlay.jpg/1280px-Hubble_Dysnomia_orbit_overlay.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/0/03/Eris%2C_Earth_%26_Moon_size_comparison.png/250px-Eris%2C_Earth_%26_Moon_size_comparison.png"
                }
            },
            new()
            {
                Name = "Ceres",
                Subtitle = "Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter. It was explored by NASA's Dawn spacecraft.",
                HeroImage = "ceres.png",
                Description = "Ceres was the first member of the asteroid belt to be discovered when Giuseppe Piazzi spotted it in 1801. Called an asteroid for many years, Ceres is so much bigger and so different from its rocky neighbors that scientists classified it as a dwarf planet in 2006. When NASA's Dawn arrived in 2015, Ceres became the first dwarf planet to receive a visit from a spacecraft.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg/290px-Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/Ceres%2C_Earth_%26_Moon_size_comparison.jpg/300px-Ceres%2C_Earth_%26_Moon_size_comparison.jpg"
                }
            },
            new()
            {
                Name = "Pluto",
                Subtitle = "Pluto was once our solar system's ninth planet, but has been reclassified as a dwarf planet. It's located in the Kuiper Belt.",
                HeroImage = "pluto.png",
                Description = "Pluto was long considered our ninth planet, but the International Astronomical Union reclassified Pluto as a dwarf planet in 2006. NASA's New Horizons was the first spacecraft to explore Pluto up close, flying by in 2015.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Pluto_in_True_Color_-_High-Res.jpg/290px-Pluto_in_True_Color_-_High-Res.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/Pluto-01_Stern_03_Pluto_Color_TXT.jpg/240px-Pluto-01_Stern_03_Pluto_Color_TXT.jpg"
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "Haumea is an oval-shaped dwarf planet that is one of the fastest rotating large objects in our solar system. The fast spin distorts Haumea's shape, making this dwarf planet look like a football.",
                HeroImage = "haumea.png",
                Description = "Two teams claim credit for discovering Haumea citing evidence from observations made in 2003 and 2004. The International Astronomical Union’s Gazetteer of Planetary Nomenclature lists the discovery location as Sierra Nevada Observatory in Spain on March 7, 2003, but no official discoverer is listed. Haumea is named after the Hawaiian goddess of fertility.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Haumea_Hubble.png/290px-Haumea_Hubble.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Haumea_Rotation.gif/213px-Haumea_Rotation.gif"
                }
            },

        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
