﻿namespace BlazorEcommerce.Server.Data;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
		modelBuilder.Entity<Category>().HasData(
				new Category
                {
					Id = 1,
					Name = "Books",
					Url = "Books"
                },
				new Category
				{ 
					Id = 2,
					Name = "Movies",
					Url = "movies"
				},
				new Category
                {
					Id = 3,
					Name = "Vide Games",
					Url = "video-games"
                }
			);

			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "The Hitchhiker's Guide to the Galaxy",
					Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film. ",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
					Price = 9.99M,
					CategoryId = 1,
				},
				new Product
				{
					Id = 2,
					Title = "Ready Player One",
					Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Ready_Player_One_cover.jpg/220px-Ready_Player_One_cover.jpg",
					Price = 12.99M,
					CategoryId = 1
				},
				new Product
				{
					Id = 3,
					Title = "Nineteen Eighty-Four",
					Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated. ",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
					Price = 15.99M,
					CategoryId = 1
				});
			}

        public DbSet<Product> Products { get; set; }

		public DbSet<Category> Categories { get; set; }
    }
