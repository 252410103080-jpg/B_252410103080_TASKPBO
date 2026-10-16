
using System;
using System.Collections.Generic;

class Item
{
    public string Judul { get; set; }
    public int Tahun { get; set; }

    public virtual void Deskripsi()
    {
        Console.WriteLine("Ini adalah item perpustakaan.");
    }

    public void InfoItem()
    {
        Console.WriteLine("Judul: " + Judul);
        Console.WriteLine("Tahun: " + Tahun);
    }
}

class Buku : Item
{
    public string Penulis { get; set; }

    public void CekPenulis()
    {
        Console.WriteLine("Penulis: " + Penulis);
    }

    public override void Deskripsi()
    {
        Console.WriteLine("Ini adalah buku.");
    }
}

class Majalah : Item
{
    public int Edisi { get; set; }

    public void InfoEdisi()
    {
        Console.WriteLine("Edisi: " + Edisi);
    }

    public override void Deskripsi()
    {
        Console.WriteLine("Ini adalah majalah.");
    }
}

class Novel : Buku
{
    public void BacaSinopsis()
    {
        Console.WriteLine("Membaca sinopsis novel.");
    }

    public override void Deskripsi()
    {
        Console.WriteLine("Ini adalah novel.");
    }
}

class Komik : Buku
{
    public void TampilkanIlustrasi()
    {
        Console.WriteLine("Menampilkan ilustrasi komik.");
    }

    public override void Deskripsi()
    {
        Console.WriteLine("Ini adalah komik.");
    }
}

class MajalahAnak : Majalah
{
    public void KategoriAnak()
    {
        Console.WriteLine("Kategori: Majalah Anak-Anak.");
    }

    public override void Deskripsi()
    {
        Console.WriteLine("Ini adalah majalah anak.");
    }
}

class MajalahTeknologi : Majalah
{
    public void TopikTeknologi()
    {
        Console.WriteLine("Topik: Teknologi.");
    }

    public override void Deskripsi()
    {
        Console.WriteLine("Ini adalah majalah teknologi.");
    }
}

class Perpustakaan
{
    private List<Item> daftarItem = new List<Item>();

    public void TambahItem(Item item)
    {
        daftarItem.Add(item);
    }

    public void DaftarItem()
    {
        foreach (Item item in daftarItem)
        {
            item.InfoItem();
            item.Deskripsi();
            Console.WriteLine("------------------");
        }
    }
}

class Program
{

    static void Main(string[] args)
    {
        Perpustakaan perpus = new Perpustakaan();

        // Membuat objek dan menambahkan item ke perpustakaan
        Buku buku = new Buku();
        buku.Judul = "Belajar C#";
        buku.Tahun = 2025;
        buku.Penulis = "Andi";
        perpus.TambahItem(buku);

        Novel novel = new Novel();
        novel.Judul = "Laut Bercerita";
        novel.Tahun = 2017;
        novel.Penulis = "Leila S. Chudori";
        perpus.TambahItem(novel);

        Komik komik = new Komik();
        komik.Judul = "Naruto";
        komik.Tahun = 1999;
        komik.Penulis = "Masashi Kishimoto";
        perpus.TambahItem(komik);

        Majalah majalah = new Majalah();
        majalah.Judul = "Majalah Remaja";
        majalah.Tahun = 2024;
        majalah.Edisi = 10;
        perpus.TambahItem(majalah);

        MajalahAnak anak = new MajalahAnak();
        anak.Judul = "Bobo";
        anak.Tahun = 2023;
        anak.Edisi = 5;
        perpus.TambahItem(anak);

        MajalahTeknologi teknologi = new MajalahTeknologi();
        teknologi.Judul = "Tech Magazine";
        teknologi.Tahun = 2025;
        teknologi.Edisi = 2;
        perpus.TambahItem(teknologi);

        // Menampilkan semua data perpustakaan
        Console.WriteLine("=== DAFTAR ITEM PERPUSTAKAAN ===");
        perpus.DaftarItem();

        // polymorphism
        Console.WriteLine("\n=== POLIMORFISME ===");
        Item item1 = novel;
        Item item2 = komik;
        Item item3 = anak;

        item1.Deskripsi();
        item2.Deskripsi();
        item3.Deskripsi();

        // Soal 1
        Console.WriteLine("\n=== SOAL 1 ===");
        novel.Deskripsi();
        majalah.Deskripsi();

        // Soal 2
        Console.WriteLine("\n=== SOAL 2 ===");
        novel.BacaSinopsis();

        // Soal 3
        Console.WriteLine("\n=== SOAL 3 ===");
        novel.InfoItem();
        novel.CekPenulis();

        // Soal 4
        Console.WriteLine("\n=== SOAL 4 ===");
        teknologi.TopikTeknologi();

        // Soal 5
        Console.WriteLine("\n=== SOAL 5 ===");
        Item itemKomik = komik;
        itemKomik.Deskripsi();

        // Soal 6
        Console.WriteLine("\n=== SOAL 6 ===");
        Console.WriteLine(
            "Inheritance memungkinkan class mewarisi anggota class induk."
        );
        Console.WriteLine(
            "Override dan polymorphism membuat method Deskripsi() " +
            "menampilkan hasil sesuai jenis objek."
        );
    }
}
