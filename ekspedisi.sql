-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 02 Mei 2016 pada 03.14
-- Versi Server: 10.1.10-MariaDB
-- PHP Version: 5.6.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ekspedisi`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `buku`
--

CREATE TABLE `buku` (
  `kode_buku` varchar(15) NOT NULL,
  `Judul` varchar(100) NOT NULL,
  `berat_koli` int(11) NOT NULL,
  `jumlah_koli` int(11) NOT NULL,
  `berat_exp` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `buku`
--

INSERT INTO `buku` (`kode_buku`, `Judul`, `berat_koli`, `jumlah_koli`, `berat_exp`) VALUES
('1000000010', 'Paket Anak Ceria 4-5 Tahun', 23, 20, 1.15),
('1000000020', 'Paket Anak Ceria 5-6 Tahun', 23, 20, 1.15),
('1000000250', 'Paket Anak Kreatif 4-5 Tahun', 22, 25, 0.88),
('1000000260', 'Paket Anak Kreatif 5-6 tahun', 22, 25, 0.88),
('1000000470', 'Aktivitas Anak Cerdas 2-4 tahun: Mengenal Angka 1-5', 23, 350, 0.0657143),
('1000000480', 'Aktivitas Anak Cerdas 2-4 tahun: Mengenal Angka 6-10', 23, 350, 0.0657143),
('1000000490', 'Aktivitas Anak Cerdas 2-4 tahun: Mengenal Huruf Vokal', 23, 350, 0.0657143),
('1000000500', 'Aktivitas Anak Cerdas 2-4 tahun: Mengenal Huruf Konsonan', 23, 350, 0.0657143),
('1000000510', 'Aktivitas Anak Cerdas 2-4 tahun: Learning ABC', 23, 350, 0.0657143),
('1000000520', 'Aktivitas Anak Cerdas 2-4 tahun: Bentuk dan Warna', 23, 350, 0.0657143),
('1000000850', 'Belajar Huruf Kecil', 22, 225, 0.0977778),
('1000000860', 'Belajar huruf Besar', 22, 225, 0.0977778),
('1000000870', 'Pengenalan Huruf Hijayah', 22, 300, 0.0733333),
('1000000880', 'Pengenalan Angka Hijayah', 22, 300, 0.0733333),
('1000000890', 'Let''s Sing and Learn 4-5 tahun', 24, 200, 0.12),
('1000000900', 'Let''s Sing and Learn 5-6 tahun', 24, 200, 0.12),
('1000000910', 'Paket Aku Anak Muslim 4-5 tahun', 21, 40, 0.525),
('1000000920', 'Paket Aku Anak Muslim 5-6 tahun', 22, 41, 0.536585),
('1000001110', 'Seri Hanif dan Hana: Haji Pertamaku', 19, 350, 0.0542857),
('1000001120', 'Seri Hanif dan Hana: Qurban Pertamaku', 20, 351, 0.0569801),
('1000001140', 'Seri Hanif dan Hana: Puasa Pertamaku', 24, 450, 0.0533333),
('1000001150', 'Seri Hanif dan Hana: Doa sehari-hari', 25, 451, 0.0554324),
('1000001160', 'Seri Hanif dan Hana: Hafalan Surat-surat Pendek', 26, 452, 0.0575221),
('1000001190', 'Seri Cerita Kreatif: Membuat Mainan Sendiri (Liburan Loli)', 17, 200, 0.085),
('1000001200', 'Seri Cerita Kreatif: Membuat Mainan Sendiri (Kejutan Untuk Simi)', 17, 200, 0.085),
('1040000710', 'BUDAK CALAKAN 3-4 Tahun', 22, 250, 0.088),
('1040000720', 'BUDAK CALAKAN 4-5 Tahun', 22, 175, 0.125714),
('1040000730', 'BUDAK CALAKAN 5-6 Tahun', 19, 150, 0.126667),
('1041000430', 'Seri Aktivitas: Aku Suka Membaca Vo. 1 (4-6 tahun)', 18, 140, 0.128571),
('1041000440', 'Seri Aktivitas: Aku Suka Membaca Vo. 2 (4-6 tahun)', 17, 150, 0.113333),
('1042000670', 'Play and Learn English untuk 4-5 tahun Semester 1', 27, 350, 0.0771429),
('1042000680', 'Play and Learn English untuk 4-5 tahun Semester 2', 27, 350, 0.0771429),
('1042000690', 'Play and Learn English untuk 5-6 tahun Semester 1', 27, 350, 0.0771429),
('1042000700', 'Play and Learn English untuk 5-6 tahun Semester 2', 27, 350, 0.0771429),
('2000000470', 'KREATIF Penjas Orkes Kelas 1', 11, 50, 0.22),
('2000000480', 'KREATIF Penjas Orkes Kelas 2', 11, 50, 0.22),
('2000000490', 'KREATIF Penjas Orkes Kelas 3', 11, 50, 0.22),
('2000000500', 'KREATIF Penjas Orkes Kelas 4', 11, 50, 0.22),
('2000000510', 'KREATIF Penjas Orkes Kelas 5', 12, 50, 0.24),
('2000000520', 'KREATIF Penjas Orkes Kelas 6', 12, 50, 0.24),
('2000000590', 'KREATIF Teknologi Informasi dan Komunikasi Kelas 1', 10, 50, 0.2),
('2000000600', 'KREATIF Teknologi Informasi dan Komunikasi Kelas 2', 12, 50, 0.24),
('2000000610', 'KREATIF Teknologi Informasi dan Komunikasi Kelas 3', 10, 50, 0.2),
('2000000620', 'KREATIF Teknologi Informasi dan Komunikasi Kelas 4', 10, 50, 0.2),
('2000000630', 'KREATIF Teknologi Informasi dan Komunikasi Kelas 5', 12, 50, 0.24),
('2000000640', 'KREATIF Teknologi Informasi dan Komunikasi Kelas 6', 10, 50, 0.2),
('2000000700', 'Tematik 1: Diri Sendiri', 12, 50, 0.24),
('2000000710', 'Tematik 1: Kegemaranku', 12, 50, 0.24),
('2000000720', 'Tematik 1: Kegiatanku', 12, 50, 0.24),
('2000000730', 'Tematik 1: Keluargaku', 12, 50, 0.24),
('2000000740', 'Tematik 1: Pengalamanku', 12, 50, 0.24),
('2000000750', 'Tematik 1: Lingkungan Bersih. Sehat. dan Asri', 12, 50, 0.24),
('2000000760', 'Tematik 1: Benda. Binatang. dan Tanaman di Sekitarku', 12, 50, 0.24),
('2000000770', 'Tematik 1: Peristiwa Alam', 10, 40, 0.25),
('2000000950', 'Tematik 4: Indahnya Kebersamaan', 14, 50, 0.28),
('2000000960', 'Tematik 4: Selalu Berhemat Energi', 14, 50, 0.28),
('2000000970', 'Tematik 4: Peduli Terhadap Makhluk Hidup', 14, 50, 0.28),
('2000000980', 'Tematik 4: Berbagai Pekerjaan', 14, 50, 0.28),
('2000000990', 'Tematik 4: Pahlawanku', 14, 50, 0.28),
('2000001000', 'Tematik 4: Indahnya Negeriku', 14, 50, 0.28),
('2000001010', 'Tematik 4: Cita-Citaku', 14, 50, 0.28),
('2000001020', 'Tematik 4: Daerah Tempat Tinggalku', 14, 50, 0.28),
('2000001030', 'Tematik 4: Makanan Sehat Bergizi', 14, 50, 0.28),
('2000001150', 'PASTI PLUS Ujian SD 2014', 14, 50, 0.28),
('2000001280', 'Belajar Menulis Halus  (Huruf Kecil)', 23, 250, 0.092),
('2000001290', 'Belajar Menulis Halus (Huruf Besar)', 23, 250, 0.092),
('2000001451', 'Simulasi PASTI Ujian 2015 Bahasa Indonesia SD/MI - Paket 1', 20, 700, 0.0285714),
('2000001461', 'Simulasi PASTI Ujian 2015 Bahasa Indonesia SD/MI - Paket 2', 20, 700, 0.0285714),
('2000001470', 'PASTI PLUS Ujian SD 2015', 13, 50, 0.26),
('2000001480', 'PASTI TOP Ujian SD 2015', 16, 50, 0.32),
('2000001551', 'Simulasi PASTI Ujian 2015 Matematika SD/MI - Paket 1', 21, 1500, 0.014),
('2000001561', 'Simulasi PASTI Ujian 2015 Matematika SD/MI - Paket 2', 21, 1500, 0.014),
('2000001651', 'Simulasi PASTI Ujian 2015 IPA SD/MI - Paket 1', 21, 1500, 0.014),
('2000001661', 'Simulasi PASTI Ujian 2015 IPA SD/MI - Paket 2', 21, 1500, 0.014),
('2000001670', 'Pengayaan Tematik 1: Diri Sendiri', 10, 50, 0.2),
('2000001680', 'Pengayaan Tematik 1: Kegemaranku', 10, 50, 0.2),
('2000001690', 'Pengayaan Tematik 1: Kegiatanku', 10, 50, 0.2),
('2000001700', 'Pengayaan Tematik 1: Keluargaku', 10, 50, 0.2),
('2000003230', 'Pasti TOP EXTRA SD/MI 2015 ( IPS & PKN )', 11, 50, 0.22),
('2000003640', 'Mahir Menulis 1 : Huruf Lepas', 18, 140, 0.128571),
('2000003650', 'Mahir Menulis 2 : Huruf Tegak Bersambung', 17, 150, 0.113333),
('2000003660', 'Mahir Menulis 3 : Kalimat Sederhana', 17, 200, 0.085),
('2000003670', 'Mahir Menulis 4 : Cerita', 17, 200, 0.085),
('2029700050', 'KREATIF Pend. Agama Islam Kelas 1', 11, 50, 0.22),
('2029700060', 'KREATIF Pend. Agama Islam Kelas 2', 11, 50, 0.22),
('2029700070', 'KREATIF Pend. Agama Islam Kelas 3', 10, 50, 0.2),
('2029700080', 'KREATIF Pend. Agama Islam Kelas 4', 11, 50, 0.22),
('2029700090', 'KREATIF Pend. Agama Islam Kelas 5', 12, 50, 0.24),
('2029700100', 'KREATIF Pend. Agama Islam Kelas 6', 10, 50, 0.2),
('2029701160', 'Pendidikan Agama Islam dan Budi Pekerti Kelas 1', 13, 50, 0.26),
('2029701170', 'Pendidikan Agama Islam dan Budi Pekerti Kelas 2', 13, 50, 0.26),
('2029701180', 'Pendidikan Agama Islam dan Budi Pekerti Kelas 3', 13, 50, 0.26),
('2029701190', 'Pendidikan Agama Islam dan Budi Pekerti Kelas 4', 13, 50, 0.26),
('2029701200', 'Pendidikan Agama Islam dan Budi Pekerti Kelas 5', 13, 50, 0.26),
('2029701210', 'Pendidikan Agama Islam dan Budi Pekerti Kelas 6', 13, 50, 0.26),
('2030000110', 'KREATIF PPKn Kelas 1', 11, 50, 0.22),
('2030000120', 'KREATIF PPKn Kelas 2', 10, 50, 0.2),
('2030000130', 'KREATIF PPKn Kelas 3', 11, 50, 0.22),
('2030000140', 'KREATIF PPKn Kelas 4', 12, 50, 0.24),
('2030000150', 'KREATIF PPKn Kelas 5', 10, 50, 0.2),
('2030000160', 'KREATIF PPKn Kelas 6', 12, 50, 0.24),
('2030000350', 'KREATIF IPS Kelas 1', 11, 50, 0.22),
('2030000360', 'KREATIF IPS Kelas 2', 12, 50, 0.24),
('2030000370', 'KREATIF IPS Kelas 3', 12, 50, 0.24),
('2030000380', 'KREATIF IPS Kelas 4', 14, 50, 0.28),
('2030000390', 'KREATIF IPS Kelas 5', 13, 50, 0.26),
('2030000400', 'KREATIF IPS Kelas 6', 13, 50, 0.26),
('2030000680', 'Pasti Fokus SD IPS', 10, 50, 0.2),
('2030000690', 'Pasti Fokus SD PKn', 10, 50, 0.2),
('2040001220', 'Basa Sunda: Budak Singer 1', 12, 50, 0.24),
('2040001230', 'Basa Sunda: Budak Singer 2', 11, 50, 0.22),
('2040001240', 'Basa Sunda: Budak Singer 3', 11, 50, 0.22),
('2040001250', 'Basa Sunda: Budak Singer 4', 12, 50, 0.24),
('2040001260', 'Basa Sunda: Budak Singer 5', 12, 50, 0.24),
('2040001270', 'Basa Sunda: Budak Singer 6', 11, 50, 0.22),
('2040002190', 'Gladhi Basa Jawa untuk Kelas 1 SD/MI', 14, 50, 0.28),
('2040002200', 'Gladhi Basa Jawa untuk Kelas 2 SD/MI', 14, 50, 0.28),
('2040002210', 'Gladhi Basa Jawa untuk Kelas 3 SD/MI', 13, 50, 0.26),
('2040002220', 'Gladhi Basa Jawa untuk Kelas 4 SD/MI', 13, 50, 0.26),
('2040002230', 'Gladhi Basa Jawa untuk Kelas 5 SD/MI', 13, 50, 0.26),
('2040002240', 'Gladhi Basa Jawa untuk Kelas 6 SD/MI', 13, 50, 0.26),
('2041000170', 'KREATIF Bahasa Indonesia Kelas 1', 12, 50, 0.24),
('2041000180', 'KREATIF Bahasa Indonesia Kelas 2', 13, 50, 0.26),
('2041000190', 'KREATIF Bahasa Indonesia Kelas 3', 13, 50, 0.26),
('2041000200', 'KREATIF Bahasa Indonesia Kelas 4', 15, 50, 0.3),
('2041000210', 'KREATIF Bahasa Indonesia Kelas 5', 13, 50, 0.26),
('2041000220', 'KREATIF Bahasa Indonesia Kelas 6', 14, 50, 0.28),
('2041000670', 'Pasti Fokus SD Bahasa Indonesia', 13, 50, 0.26),
('2042000530', 'KREATIF Bahasa Inggris Kelas 1', 15, 50, 0.3),
('2042000540', 'KREATIF Bahasa Inggris Kelas 2', 16, 50, 0.32),
('2042000550', 'KREATIF Bahasa Inggris Kelas 3', 15, 50, 0.3),
('2042000560', 'KREATIF Bahasa Inggris Kelas 4', 16, 50, 0.32),
('2042000570', 'KREATIF Bahasa Inggris Kelas 5', 16, 50, 0.32),
('2042000580', 'KREATIF Bahasa Inggris Kelas 6', 16, 50, 0.32),
('2050000290', 'KREATIF IPA Kelas 1', 11, 50, 0.22),
('2050000300', 'KREATIF IPA Kelas 2', 12, 50, 0.24),
('2050000310', 'KREATIF IPA Kelas 3', 12, 50, 0.24),
('2050000320', 'KREATIF IPA Kelas 4', 13, 50, 0.26),
('2050000330', 'KREATIF IPA Kelas 5', 14, 50, 0.28),
('2050000340', 'KREATIF IPA Kelas 6', 14, 50, 0.28),
('2050000650', 'Pasti Fokus SD IPA', 13, 50, 0.26),
('2051000230', 'KREATIF Matematika Kelas 1', 11, 50, 0.22),
('2051000240', 'KREATIF Matematika Kelas 2', 12, 50, 0.24),
('2051000250', 'KREATIF Matematika Kelas 3', 12, 50, 0.24),
('2051000260', 'KREATIF Matematika Kelas 4', 14, 50, 0.28),
('2051000270', 'KREATIF Matematika Kelas 5', 13, 50, 0.26),
('2051000280', 'KREATIF Matematika Kelas 6', 13, 50, 0.26),
('2051000660', 'Pasti Fokus SD Matematika', 13, 50, 0.26),
('2070000410', 'KREATIF Seni Budaya Ketrampilan Kelas 1', 11, 50, 0.22),
('2070000420', 'KREATIF Seni Budaya Ketrampilan Kelas 2', 11, 50, 0.22),
('2070000430', 'KREATIF Seni Budaya Ketrampilan Kelas 3', 11, 50, 0.22),
('2070000440', 'KREATIF Seni Budaya Ketrampilan Kelas 4', 12, 50, 0.24),
('2070000450', 'KREATIF Seni Budaya Ketrampilan Kelas 5', 12, 50, 0.24),
('2070000460', 'KREATIF Seni Budaya Ketrampilan Kelas 6', 11, 50, 0.22),
('2129700290', 'KREATIF Belajar Al Qur''an & Hadits Kelas 1', 11, 50, 0.22),
('2129700300', 'KREATIF Belajar Al Qur''an & Hadits Kelas 2', 11, 50, 0.22),
('2129700310', 'KREATIF Belajar Al Qur''an & Hadits Kelas 3', 11, 50, 0.22),
('2129700320', 'KREATIF Belajar Al Qur''an & Hadits Kelas 4', 13, 50, 0.26),
('2129700330', 'KREATIF Belajar Al Qur''an & Hadits Kelas 5', 13, 50, 0.26),
('2129700340', 'KREATIF Belajar Al Qur''an & Hadits Kelas 6', 13, 50, 0.26),
('2129700350', 'KREATIF Belajar Fiqih Kelas 1', 10, 50, 0.2),
('2129700360', 'KREATIF Belajar Fiqih Kelas 2', 10, 50, 0.2),
('2129700370', 'KREATIF Belajar Fiqih Kelas 3', 10, 50, 0.2),
('2129700380', 'KREATIF Belajar Fiqih Kelas 4', 10, 50, 0.2),
('2129700390', 'KREATIF Belajar Fiqih Kelas 5', 10, 50, 0.2),
('2129700410', 'KREATIF Belajar Aqidah Ahklak Kelas 1', 12, 50, 0.24),
('2129700420', 'KREATIF Belajar Aqidah Ahklak Kelas 2', 11, 50, 0.22),
('2129700440', 'KREATIF Belajar Aqidah Ahklak Kelas 4', 13, 50, 0.26),
('2129700450', 'KREATIF Belajar Aqidah Ahklak Kelas 5', 13, 50, 0.26),
('2129700460', 'KREATIF Belajar Aqidah Ahklak Kelas 6', 13, 50, 0.26),
('2129700470', 'KREATIF Belajar Sejarah Kebudayaan Islam Kelas 3', 10, 50, 0.2),
('2129700480', 'KREATIF Belajar Sejarah Kebudayaan Islam Kelas 4', 10, 50, 0.2),
('2129700490', 'KREATIF Belajar Sejarah Kebudayaan Islam Kelas 5', 10, 50, 0.2),
('2129700510', 'KREATIF Belajar Bahasa Arab Kelas 1', 10, 50, 0.2),
('2129700520', 'KREATIF Belajar Bahasa Arab Kelas 2', 10, 50, 0.2),
('2129700530', 'KREATIF Belajar Bahasa Arab Kelas 3', 10, 50, 0.2),
('2129700550', 'KREATIF Belajar Bahasa Arab Kelas 5', 11, 50, 0.22),
('2129700630', 'Tamam : UAM MI 2015', 12, 50, 0.24),
('3000000291', 'PASTI PLUS UN SMP 2015', 15, 50, 0.3),
('3000000300', 'PASTI TOP Ujian SMP/MTs 2015', 18, 50, 0.36),
('3000000551', 'Simulasi PASTI UN 2015 Bahasa Indonesia SMP/MTs - Paket 1', 24, 700, 0.0342857),
('3000000651', 'Simulasi PASTI UN 2015 Bahasa Inggris SMP/MTs - Paket 1', 23, 1100, 0.0209091),
('3000000751', 'Simulasi PASTI UN 2015 Matematika SMP/MTs - Paket 1', 21, 1500, 0.014),
('3000000851', 'Simulasi PASTI UN 2015 IPA SMP/MTs - Paket 1', 22, 1500, 0.0146667),
('3029700340', 'PASTI BISA: Pendidikan Agama Islam  SMP 1', 12, 50, 0.24),
('3029700350', 'PASTI BISA: Pendidikan Agama Islam  SMP 2', 12, 50, 0.24),
('3030000490', 'PASTI BISA: IPS SMP 1', 11, 50, 0.22),
('3030001310', 'KTSP : PASTI BISA: IPS SMP 1', 14, 50, 0.28),
('3030001340', 'KTSP : PASTI BISA: PKn SMP 1', 9, 50, 0.18),
('3040000920', 'Lantip Basa Jawa kanggo Kelas 1 SMP/MTs', 12, 50, 0.24),
('3040000930', 'Lantip Basa Jawa kanggo Kelas 2 SMP/MTs', 12, 50, 0.24),
('3040000940', 'Lantip Basa Jawa kanggo Kelas 3 SMP/MTs', 12, 50, 0.24),
('3041000030', 'Pasti Fokus SMP Bahasa Indonesia', 14, 50, 0.28),
('3041000370', 'PASTI BISA: Bahasa Indonesia SMP 1', 13, 50, 0.26),
('3041000380', 'PASTI BISA: Bahasa Indonesia SMP 2', 14, 50, 0.28),
('3041001070', 'Explore: Bahasa Indonesia SMP 3 (KTSP)', 8, 50, 0.16),
('3041001190', 'KTSP : PASTI BISA: Bahasa Indonesia SMP 1', 15, 50, 0.3),
('3042000050', 'Pasti Fokus SMP Bhs. Inggris', 15, 50, 0.3),
('3042000400', 'PASTI BISA: Bahasa Inggris SMP 1', 9, 50, 0.18),
('3042000410', 'PASTI BISA: Bahasa Inggris SMP 2', 11, 50, 0.22),
('3042001220', 'KTSP : PASTI BISA: Bahasa Inggris SMP 1', 11, 50, 0.22),
('3050000020', 'Pasti Fokus SMP IPA', 17, 50, 0.34),
('3050000470', 'PASTI BISA: IPA SMP 2', 13, 50, 0.26),
('3050001100', 'Explore: IPA SMP 1 (KTSP)', 16, 40, 0.4),
('3050001280', 'KTSP : PASTI BISA: IPA SMP 1', 13, 50, 0.26),
('3050001290', 'KTSP : PASTI BISA: IPA SMP 2', 14, 50, 0.28),
('3051000040', 'Pasti Fokus SMP Matematika', 15, 50, 0.3),
('3051000170', 'Explore: Matematika SMP 1 (Kur.2013)', 14, 30, 0.466667),
('3051000430', 'PASTI BISA: Matematika SMP Kelas 1', 12, 50, 0.24),
('3051000440', 'PASTI BISA: Matematika SMP Kelas 2', 13, 50, 0.26),
('3051001130', 'KTSP : Explore: Matematika SMP Kelas 1', 18, 40, 0.45),
('3051001250', 'KTSP: PASTI BISA: Matematika SMP Kelas 1', 10, 50, 0.2),
('3051001260', 'KTSP: PASTI BISA: Matematika SMP Kelas 2', 10, 50, 0.2),
('4000000531', 'PASTI PLUS UN SMA IPA 2015', 14, 50, 0.28),
('4000000540', 'PASTI PLUS UN SMA IPS 2014', 14, 50, 0.28),
('4000000541', 'PASTI PLUS UN SMA IPS 2015', 15, 50, 0.3),
('4029700660', 'PASTI BISA: Pendidikan Agama Islam SMA Kelas 1', 12, 50, 0.24),
('4029700670', 'PASTI BISA: Pendidikan Agama Islam SMA Kelas 2', 13, 50, 0.26),
('4030001540', 'Explore: Pendidikan Kewarganegaraan SMA 1 (KTSP)', 18, 50, 0.36),
('4030001780', 'KTSP : PASTI BISA: Pendidikan Kewarganegaraan SMA Kelas 1', 11, 50, 0.22),
('4030100070', 'Pasti Fokus SMA Sosiologi', 13, 50, 0.26),
('4030101630', 'Explore: Sosiologi SMA 1 (KTSP)', 17, 50, 0.34),
('4030102080', 'KTSP : PASTI BISA: Sosiologi SMA Kelas 1', 11, 50, 0.22),
('4033000090', 'Pasti Fokus SMA Ekonomi', 14, 50, 0.28),
('4033001020', 'PASTI BISA: Ekonomi SMA Kelas 1', 13, 50, 0.26),
('4033001030', 'PASTI BISA: Ekonomi SMA Kelas 2', 11, 50, 0.22),
('4033002050', 'KTSP : PASTI BISA: Ekonomi SMA Kelas 1', 13, 50, 0.26),
('4040001210', 'Wiyata Basa kanggo SMA/MA 1', 12, 50, 0.24),
('4040001220', 'Wiyata Basa kanggo SMA/MA 2', 12, 50, 0.24),
('4040001230', 'Wiyata Basa kanggo SMA/MA 3', 10, 50, 0.2),
('4041000010', 'Pasti Fokus SMA Bahasa Indonesia', 12, 50, 0.24),
('4041000690', 'PASTI BISA: Bahasa Indonesia SMA 1', 13, 50, 0.26),
('4041000700', 'PASTI BISA: Bahasa Indonesia SMA 2', 14, 50, 0.28),
('4041001720', 'KTSP : PASTI BISA: Bahasa Indonesia SMA 1 ', 15, 50, 0.3),
('4042000020', 'Pasti Fokus SMA Bahasa Inggris', 16, 50, 0.32),
('4042000720', 'PASTI BISA: Bahasa Inggris SMA 1', 11, 50, 0.22),
('4050000060', 'Pasti Fokus SMA Biologi', 14, 50, 0.28),
('4050000900', 'PASTI BISA: Biologi SMA 1', 13, 50, 0.26),
('4050000910', 'PASTI BISA: Biologi SMA 2', 13, 50, 0.26),
('4050001930', 'KTSP : PASTI BISA: Biologi SMA 1', 13, 50, 0.26),
('4050001940', 'KTSP : PASTI BISA: Biologi SMA 2', 13, 50, 0.26),
('4051000030', 'Pasti Fokus SMA Matematika', 12, 50, 0.24),
('4051000780', 'PASTI BISA: Matematika SMA 1', 16, 50, 0.32),
('4051000790', 'PASTI BISA: Matematika SMA 2', 16, 50, 0.32),
('4051000810', 'PASTI BISA: Matematika IPA SMA 1', 12, 50, 0.24),
('4051001450', 'Explore: Matematika IPA SMA 1 (KTSP)', 12, 20, 0.6),
('4051001480', 'Explore: Matematika SMA 1 (KTSP)', 12, 50, 0.24),
('4051001810', 'KTSP : PASTI BISA: Matematika SMA 1', 12, 50, 0.24),
('4051001820', 'KTSP : PASTI BISA: Matematika SMA 2', 13, 50, 0.26),
('4053000040', 'Pasti Fokus SMA Fisika', 16, 50, 0.32),
('4053000930', 'PASTI BISA: Fisika SMA 1', 11, 50, 0.22),
('4053000940', 'PASTI BISA: Fisika SMA 2', 12, 50, 0.24),
('4053001080', 'Akselerasi Fisika SMA 1 (Kur.2013)', 15, 50, 0.3),
('4053001090', 'Akselerasi Fisika SMA 2 (Kur.2013)', 15, 50, 0.3),
('4053001660', 'Akselerasi Fisika SMA 1 (KTSP)', 15, 20, 0.75),
('4053001670', 'Akselerasi Fisika SMA 2 (KTSP)', 15, 20, 0.75),
('4053001680', 'Akselerasi Fisika SMA 3 (KTSP)', 15, 20, 0.75),
('4053001960', 'KTSP : PASTI BISA: Fisika SMA 1', 12, 50, 0.24),
('4053001970', 'KTSP : PASTI BISA: Fisika SMA 2', 13, 50, 0.26),
('4054000050', 'Pasti Fokus SMA Kimia', 12, 50, 0.24),
('4054000960', 'PASTI BISA: Kimia SMA 1', 10, 50, 0.2),
('4054000970', 'PASTI BISA: Kimia SMA 2', 12, 50, 0.24),
('4054001420', 'Explore: Kimia SMA 1 (KTSP)', 17, 40, 0.425),
('4054001990', 'KTSP : Pasti Bisa Kimia SMA 1', 10, 50, 0.2),
('4054002000', 'KTSP : Pasti Bisa Kimia SMA 2', 12, 50, 0.24),
('4090000100', 'Pasti Fokus SMA Sejarah', 13, 50, 0.26),
('4090000840', 'PASTI BISA: Sejarah SMA 1', 9, 50, 0.18),
('4090000850', 'PASTI BISA: Sejarah SMA 2', 11, 50, 0.22),
('4090001570', 'Explore: Sejarah IPS SMA 1 (KTSP)', 12, 50, 0.24),
('4090001870', 'KTSP : PASTI BISA: Sejarah SMA 1', 11, 50, 0.22),
('4091000080', 'Pasti Fokus SMA Geografi', 13, 50, 0.26),
('4091000990', 'PASTI BISA: Geografi SMA 1', 13, 50, 0.26),
('4091001000', 'PASTI BISA: Geografi SMA 2', 13, 50, 0.26),
('4091002020', 'KTSP : PASTI BISA: Geografi SMA 1', 10, 50, 0.2),
('4091002030', 'KTSP : PASTI BISA: Geografi SMA 2', 10, 50, 0.2),
('kode_buku', 'judul', 0, 0, 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `cabang`
--

CREATE TABLE `cabang` (
  `id` int(11) NOT NULL,
  `nama_cabang` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `cabang`
--

INSERT INTO `cabang` (`id`, `nama_cabang`) VALUES
(1, 'Bandung'),
(2, 'Surabaya'),
(4, 'solo'),
(5, 'Pusat'),
(6, 'Tasikmalaya'),
(7, 'Cirebon'),
(8, 'Bali'),
(9, 'Praya'),
(10, 'Mataram'),
(11, 'Jakarta'),
(12, 'Bekasi'),
(13, 'Bogor'),
(14, 'Depok'),
(15, 'Jember'),
(16, 'Lampung'),
(17, 'Madiun'),
(18, 'Makassar'),
(19, 'Malang'),
(20, 'Kediri'),
(21, 'Medan'),
(23, 'Padang'),
(24, 'Palembang'),
(25, 'Semarang'),
(26, 'Bangkalan'),
(27, 'Pamekasan'),
(28, 'Sidoarjo'),
(29, 'Yogyakarta'),
(30, 'Purwokerto'),
(31, 'Pematang Siantar'),
(32, 'Serang'),
(33, 'Tanggerang');

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_invoice`
--

CREATE TABLE `detail_invoice` (
  `id` int(11) NOT NULL,
  `nsj` varchar(25) NOT NULL,
  `kode_buku` varchar(15) NOT NULL,
  `jumlah_koli` int(11) NOT NULL,
  `jumlah_exp` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `detail_invoice`
--

INSERT INTO `detail_invoice` (`id`, `nsj`, `kode_buku`, `jumlah_koli`, `jumlah_exp`) VALUES
(1, 'NSJ-001', '1000000010', 5, 100),
(2, 'NSJ-001', '1000000020', 5, 100),
(3, 'NSJ-001', '1000000250', 14, 350),
(4, 'NSJ-001', '1000000260', 16, 400),
(5, 'NSJ-002', '1000000010', 5, 100),
(6, 'NSJ-002', '1000000020', 5, 100),
(7, 'NSJ-002', '1000000250', 14, 350),
(8, 'NSJ-002', '1000000260', 16, 400),
(9, 'NSJ-004', '1000000010', 12, 250),
(10, 'NSJ-004', '1000000020', 6, 130),
(11, 'NSJ-004', '1000000250', 5, 120),
(12, 'NSJ-004', '1000000260', 17, 430);

-- --------------------------------------------------------

--
-- Struktur dari tabel `detai_ekspedisi`
--

CREATE TABLE `detai_ekspedisi` (
  `id` int(11) NOT NULL,
  `id_ekspedisi` int(11) NOT NULL,
  `id_cabang` int(11) NOT NULL,
  `harga` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `detai_ekspedisi`
--

INSERT INTO `detai_ekspedisi` (`id`, `id_ekspedisi`, `id_cabang`, `harga`) VALUES
(1, 1, 7, '7000'),
(3, 1, 26, '7000'),
(4, 6, 1, '8000'),
(5, 4, 13, '9'),
(6, 5, 12, '8500'),
(7, 5, 14, '7000'),
(8, 8, 11, '7500');

-- --------------------------------------------------------

--
-- Struktur dari tabel `ekspedisi`
--

CREATE TABLE `ekspedisi` (
  `id` int(11) NOT NULL,
  `nama_ekspedisi` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `ekspedisi`
--

INSERT INTO `ekspedisi` (`id`, `nama_ekspedisi`) VALUES
(1, 'JNE'),
(3, 'TIKI'),
(4, 'Ekspedisi A'),
(5, 'Ekspedisi B'),
(6, 'Ekspedisi C'),
(7, 'Ekspedisi D'),
(8, 'Ekspedisi Z'),
(9, 'Ekspedisi F');

-- --------------------------------------------------------

--
-- Struktur dari tabel `invoice`
--

CREATE TABLE `invoice` (
  `nsj` varchar(25) NOT NULL,
  `Tanggal` varchar(12) NOT NULL,
  `id_ekspedisi` int(11) NOT NULL,
  `id_cabang` int(11) NOT NULL,
  `total_koli` int(11) NOT NULL,
  `total_exp` double DEFAULT NULL,
  `total_berat` double NOT NULL,
  `sub_total_tagihan` double NOT NULL,
  `status` varchar(1) DEFAULT NULL,
  `no_Invoice` varchar(15) DEFAULT NULL,
  `tgl_invoice` varchar(10) DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `invoice`
--

INSERT INTO `invoice` (`nsj`, `Tanggal`, `id_ekspedisi`, `id_cabang`, `total_koli`, `total_exp`, `total_berat`, `sub_total_tagihan`, `status`, `no_Invoice`, `tgl_invoice`, `user_id`) VALUES
('NSJ-001', '22/04/2016', 5, 12, 40, NULL, 890, 7565000, '1', 'INV-001', '26/04/2016', 0),
('NSJ-002', '24/04/2016', 5, 12, 40, NULL, 890, 7565000, '1', 'INV-001', '26/04/2016', 0),
('NSJ-004', '25/04/2016', 5, 14, 40, NULL, 920, 6447000, '1', 'INV-002', '26/04/2016', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `user_name` varchar(40) NOT NULL,
  `user_username` varchar(40) NOT NULL,
  `user_pass` varchar(90) NOT NULL,
  `user_type` varchar(20) NOT NULL,
  `status` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `users`
--

INSERT INTO `users` (`user_id`, `user_name`, `user_username`, `user_pass`, `user_type`, `status`) VALUES
(1, 'Rehan', 'rehan', '123456', 'SA', 'aktif');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `buku`
--
ALTER TABLE `buku`
  ADD PRIMARY KEY (`kode_buku`);

--
-- Indexes for table `cabang`
--
ALTER TABLE `cabang`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `detail_invoice`
--
ALTER TABLE `detail_invoice`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `detai_ekspedisi`
--
ALTER TABLE `detai_ekspedisi`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `ekspedisi`
--
ALTER TABLE `ekspedisi`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `invoice`
--
ALTER TABLE `invoice`
  ADD PRIMARY KEY (`nsj`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `user_name_2` (`user_name`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cabang`
--
ALTER TABLE `cabang`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;
--
-- AUTO_INCREMENT for table `detail_invoice`
--
ALTER TABLE `detail_invoice`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `detai_ekspedisi`
--
ALTER TABLE `detai_ekspedisi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `ekspedisi`
--
ALTER TABLE `ekspedisi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
