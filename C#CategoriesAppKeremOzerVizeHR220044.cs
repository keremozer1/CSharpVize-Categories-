Category mainCategoryMutfak = new Category("Mutfak");

Category subCategoryOcak = new Category("Ocak");
Category subCategoryFirin = new Category("Fırın");
Category subCategoryBuzdolabi = new Category("Buz Dolabı");
Category subCategoryTostmakinesi = new Category("Tost Makinesi");
Category subCategoryTava = new Category("Tava");
Category subCategoryCatalbicakseti = new Category("Çatal/Bıçak Seti");
Category subCategoryBardak = new Category("Bardak");

Category mainCategoryTeknoloji = new Category("Teknoloji");

Category subCategoryLaptop = new Category("Laptop");
Category subCategoryMasaustubilgisayar = new Category("Masaüstü Bilgisayar");
Category subCategoryOyunkonsollari = new Category("Oyun Konsolları");
Category subCategoryTelefon = new Category("Telefon");
Category subCategoryDrone = new Category("Drone");
Category subCategoryTelevizyon = new Category("Televizyon");
Category subCategoryVr = new Category("VR");

Category mainCategoryDekorasyon = new Category("Dekorasyon");

Category subCategoryParke = new Category("Parke");
Category subCategoryBiblo = new Category("Biblo");
Category subCategoryTablo = new Category("Tablo");
Category subCategorySaat = new Category("Saat");
Category subCategoryMum = new Category("Mum");
Category subCategoryMasa = new Category("Masa");

Category mainCategoryHobi = new Category("Hobi");

Category subCategoryGitar = new Category("Gitar");
Category subCategoryMasatenisi = new Category("Masa Tenisi");
Category subCategoryBisiklet = new Category("Bisiklet");
Category subCategoryUzaktankumandaliaraba = new Category("Uzaktan Kumandalı RC Araba");
Category subCategoryBarbie = new Category("Barbie");
Category subCategoryFilmler = new Category("Filmler");
Category subCategoryResim = new Category("Resim");


mainCategoryTeknoloji.AddSubcategory(subCategoryLaptop);
mainCategoryTeknoloji.AddSubcategory(subCategoryMasaustubilgisayar);
mainCategoryTeknoloji.AddSubcategory(subCategoryOyunkonsollari);
mainCategoryTeknoloji.AddSubcategory(subCategoryTelefon);
mainCategoryTeknoloji.AddSubcategory(subCategoryDrone);
mainCategoryTeknoloji.AddSubcategory(subCategoryTelevizyon);
mainCategoryTeknoloji.AddSubcategory(subCategoryVr);

mainCategoryMutfak.AddSubcategory(subCategoryOcak);
mainCategoryMutfak.AddSubcategory(subCategoryFirin);
mainCategoryMutfak.AddSubcategory(subCategoryBuzdolabi);
mainCategoryMutfak.AddSubcategory(subCategoryTostmakinesi);
mainCategoryMutfak.AddSubcategory(subCategoryTava);
mainCategoryMutfak.AddSubcategory(subCategoryCatalbicakseti);
mainCategoryMutfak.AddSubcategory(subCategoryBardak);
mainCategoryMutfak.AddSubcategory(subCategoryMasa);

mainCategoryDekorasyon.AddSubcategory(subCategoryParke);
mainCategoryDekorasyon.AddSubcategory(subCategoryBiblo);
mainCategoryDekorasyon.AddSubcategory(subCategoryTablo);
mainCategoryDekorasyon.AddSubcategory(subCategorySaat);
mainCategoryDekorasyon.AddSubcategory(subCategoryMum);
mainCategoryDekorasyon.AddSubcategory(subCategoryMasa);
mainCategoryDekorasyon.AddSubcategory(subCategoryTelevizyon);

mainCategoryHobi.AddSubcategory(subCategoryGitar);
mainCategoryHobi.AddSubcategory(subCategoryMasatenisi);
mainCategoryHobi.AddSubcategory(subCategoryBisiklet);
mainCategoryHobi.AddSubcategory(subCategoryUzaktankumandaliaraba);
mainCategoryHobi.AddSubcategory(subCategoryFilmler);
mainCategoryHobi.AddSubcategory(subCategoryResim);


Category.Print(mainCategoryMutfak);
Category.Print(mainCategoryTeknoloji);
Category.Print(mainCategoryDekorasyon);
Category.Print(mainCategoryHobi);


public class Category
{
    public string Name { get; set; }
    public List<Category> Subcategories { get; set; }
    public Category(string name)
    {
        Name = name;
        Subcategories = new List<Category>();
    }
    public void AddSubcategory(Category subcategory)
    {
        Subcategories.Add(subcategory);
    }
    public void RemoveSubcategory(Category subcategory)
    {
        Subcategories.Remove(subcategory);
    }
    public static void Print(Category category)
    {
        Console.WriteLine("Kategori: " + category.Name);
        for (int i = 0; i < category.Subcategories.Count; i++)
        {
            Console.WriteLine("  Alt kategori: " + category.Subcategories[i].Name);
            if (category.Subcategories[i].Subcategories.Count > 0)
            {
                Print(category.Subcategories[i]);
            }
        }
    }
}

