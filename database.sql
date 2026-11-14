CREATE TABLE pengguna (
    id SERIAL PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    nama_lengkap VARCHAR(100) NOT NULL,
    role VARCHAR(20) NOT NULL,
    is_delete BOOLEAN DEFAULT FALSE
);

CREATE TABLE jenis_keuangan (
    id SERIAL PRIMARY KEY,
    nama_jenis VARCHAR(100) NOT NULL,
    kategori VARCHAR(20) NOT NULL,
    is_delete BOOLEAN DEFAULT FALSE
);

CREATE TABLE lahan (
    id SERIAL PRIMARY KEY,
    nama_lokasi VARCHAR(100) NOT NULL,
    luas_lahan NUMERIC(10,2) NOT NULL,
    catatan VARCHAR(255),
    is_delete BOOLEAN DEFAULT FALSE
);

CREATE TABLE keuangan (
    id SERIAL PRIMARY KEY,
    id_pengguna INT REFERENCES pengguna(id),
    id_jenis_keuangan INT REFERENCES jenis_keuangan(id),
    tanggal DATE NOT NULL,
    jumlah NUMERIC(15,2) NOT NULL,
    keterangan VARCHAR(255),
    is_delete BOOLEAN DEFAULT FALSE
);

CREATE TABLE budidaya_tebu (
    id SERIAL PRIMARY KEY,
    id_lahan INT REFERENCES lahan(id),
    tanggal_tanam DATE NOT NULL,
    tanggal_panen DATE,
    jumlah_tebu INT NOT NULL,
    status VARCHAR(50) DEFAULT 'Masa Tanam',
    is_delete BOOLEAN DEFAULT FALSE
);

INSERT INTO pengguna (username, password, nama_lengkap, role) VALUES 
('owner', '123', 'Bapak Eddy Sumarno', 'Petani'),
('buruh', '123', 'Andi Wijaya', 'Buruh Tani');