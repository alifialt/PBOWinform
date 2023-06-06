create table laptop(
	id_laptop int primary key,
	nama_laptop varchar(20),
	harga int,
	stok int
);

create table transaksi(
	id_transaksi serial primary key,
	nama_pembeli varchar(20)
);

create table transaksi_detail(
	id_detail_transaksi serial primary key,
	laptop_dibeli varchar(20),
	stok_dibeli int
);

select laptop.nama_laptop, laptop.harga, laptop.stok, transaksi.nama_pembeli, transaksi_detail.laptop_dibeli, transaksi_detail.stok_dibeli from laptop join transaksi_detail on laptop.nama_laptop = transaksi_detail.laptop_dibeli join transaksi ON transaksi_detail.id_detail_transaksi = transaksi.id_transaksi;
