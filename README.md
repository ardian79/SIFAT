# SIFAT - Sistem Informasi Pengelolaan Keuangan Budidaya Tebu

SIFAT adalah aplikasi desktop berbasis **C# Windows Forms** yang dirancang khusus untuk membantu para petani dan buruh tani dalam mengelola keuangan serta mencatat aktivitas budidaya tanaman tebu secara digital, rapi, dan terintegrasi.

Proyek ini dibangun sebagai pemenuhan **Tugas Akhir mata kuliah Pemrograman Berorientasi Objek (PBO)**.

## Fitur Utama

Aplikasi ini menerapkan sistem *Role-Based Access Control* (Hak Akses Berdasarkan Peran):

1. **Multi-User Login** (Petani/Owner dan Buruh Tani).
2. **Dashboard** (Ringkasan Total Pemasukan, Pengeluaran, dan Saldo Kas *real-time*).
3. **Manajemen Data Lahan** (Pencatatan lokasi dan luas lahan).
4. **Manajemen Jenis Keuangan** (Kategori Pemasukan & Pengeluaran).
5. **Manajemen Data Keuangan** (Buku kas harian dengan fitur CRUD).
6. **Manajemen Budidaya Tebu** (Pencatatan siklus tanam & panen).
7. **Kelola Buruh Tani** (Khusus Petani untuk mengelola akun karyawan).

## Teknologi & Arsitektur

- **Bahasa:** C# (.NET Windows Forms)
- **Database:** PostgreSQL
- **Library:** Npgsql
- **Arsitektur:** MVC (Model-View-Controller) & Repository Pattern
- **Konsep OOP:** Menerapkan 4 Pilar OOP (Encapsulation, Inheritance, Polymorphism, Abstraction)

---

## Tampilan Aplikasi

### 1. Halaman Login

Halaman masuk untuk Petani dan Buruh Tani dengan desain *Full Screen* dan *Card* elegan.

![Halaman Login](images/login.png)

### 2. Halaman Dashboard (Petani)

Menampilkan ringkasan total pemasukan, pengeluaran, dan saldo kas secara otomatis.

![Halaman Dashboard](images/dashboard.png)

### 3. Manajemen Data Lahan

Halaman untuk mencatat daftar lahan yang dimiliki beserta luasnya.

![Halaman Lahan](images/lahan.png)

### 4. Manajemen Jenis Keuangan

Halaman pengaturan kategori (Master Data) untuk transaksi keuangan.

![Halaman Jenis Keuangan](images/jenis-keuangan.png)

### 5. Manajemen Data Keuangan (Buku Kas)

Halaman pencatatan uang masuk dan keluar beserta keterangannya.

![Halaman Keuangan](images/keuangan.png)

### 6. Manajemen Budidaya Tebu

Halaman pencatatan tanggal tanam, jumlah tebu, dan status panen.

![Halaman Budidaya](images/budidaya.png)

### 7. Manajemen Kelola Buruh Tani (Khusus Petani)

Halaman untuk Petani mendaftarkan, mereset password, atau menonaktifkan akun Buruh Tani.

![Halaman Kelola Buruh](images/kelola-buruh.png)

---

## Cara Menjalankan Proyek

1. **Clone Repositori ini:**

   ```bash
   git clone https://github.com/ardian79/SIFAT.git
   ```

2. **Buka di Visual Studio:**

   Buka file `SIFAT.sln` menggunakan Visual Studio 2022.

3. **Install Dependencies:**

   Buka *NuGet Package Manager* dan pastikan library **Npgsql** sudah terinstal.

4. **Siapkan Database:**

   - Buat database baru di PostgreSQL dengan nama `SIFAT`.
   - Jalankan script SQL yang terdapat pada file `database.sql`.

5. **Sesuaikan Koneksi:**

   Buka file `Database/Koneksi.cs` dan sesuaikan `Username` serta `Password` dengan pengaturan PostgreSQL di komputermu.

6. **Jalankan Aplikasi:**

   Tekan `F5` atau klik *Start* di Visual Studio.

## Tim Pengembang

- **Youhana Aulia Zahwa**
- **Felix Jericho Moniaga**
- **Rizal Lazuardi**
- **Muhammad Davin Ardiansyah**
- **Aji Pangestu**

---

*Dibuat untuk memenuhi Tugas Akhir Mata Kuliah Pemrograman Berorientasi Objek (PBO) - Universitas Jember.*