﻿using FoodSupplementsSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSupplementsSystem.Data.Migrations
{
    public class SeedData
    {
        public static Random Rand = new Random();

        public List<Category> Categories;

        public List<Topic> Topics;

        public List<Brand> Brands;

        public List<Supplement> Supplements;

        public User Author { get; set; }

        public SeedData(User author)
        {
            this.Categories = new List<Category>();
            Categories.Add(new Category() { Name = "Category1" });
            Categories.Add(new Category() { Name = "Category2" });
            Categories.Add(new Category() { Name = "Category3" });
            Categories.Add(new Category() { Name = "Category4" });
            Categories.Add(new Category() { Name = "Category5" });
            Categories.Add(new Category() { Name = "Category6" });
            Categories.Add(new Category() { Name = "Category7" });

            this.Topics = new List<Topic>();
            //0
            Topics.Add(new Topic()
            {
                Name = "Anti-Aging",
                Description = "Hormones including DHEA and Progesterone, Antioxidants, and Face Cream with CoQ10."
            });
            //1
            Topics.Add(new Topic()
            {
                Name = "Brain Health",
                Description = "The brain controls almost all body processes, including heartbeat, breathing, digestion, muscle movement, and speech, as well as all five senses. The brain is also responsible for memory, emotion, and reasoning."
            });
            //2
            Topics.Add(new Topic()
            {
                Name = "Cardiovascular Support",
                Description = "Proper nutrition promotes healthy circulation."
            });
            //3
            Topics.Add(new Topic()
            {
                Name = "Detox & Clensing",
                Description = "Intestinal and Cellular Cleansing Products Including: Detoxification, Colon Cleanse, Toxin Absorption, and Heavy Metal Detox."
            });
            //4
            Topics.Add(new Topic()
            {
                Name = "Emotional Well Being",
                Description = "Emotional wellness influences the quality of life and also impacts physical health. It’s often debatable which comes first."
            });
            //5
            Topics.Add(new Topic()
            {
                Name = "Energy Support",
                Description = "Balancing family, work, health, errands and social engagements can be difficult to endure. It might not be possible to slow down the demands of life, but it is possible to fuel up naturally with supplements and a proper diet."
            });
            //6
            Topics.Add(new Topic()
            {
                Name = "Eye Health",
                Description = "Your eyes are an important part of your health. There are many things you can do to keep them healthy and make sure you are seeing your best."
            });

            this.Brands = new List<Brand>();
            //0
            Brands.Add(new Brand()
            {
                Name = "Nordic Naturals",
                WebSite = "https://www.nordicnaturals.com"
            });
            //1
            Brands.Add(new Brand()
            {
                Name = "Pure Encapsulation",
                WebSite = "https://www.pureencapsulations.com"
            });
            //2
            Brands.Add(new Brand()
            {
                Name = "Life Extension",
                WebSite = "http://www.lifeextension.com"
            });
            //3
            Brands.Add(new Brand()
            {
                Name = "American Biologics",
                WebSite = "http://americanbiologics.com/renewal_factor1.shtml"
            });
            //4
            Brands.Add(new Brand()
            {
                Name = "Anabolic Laboratories",
                WebSite = "http://www.anaboliclabs.com"
            });
            //5
            Brands.Add(new Brand()
            {
                Name = "Douglas Labs",
                WebSite = "https://www.douglaslabs.com"
            });

            this.Author = author;
            User user = author;

            this.Supplements = new List<Supplement>();
            Supplements.Add(new Supplement()
            {
                Category = Categories[0],
                Topic = Topics[6],
                Brand = Brands[0],
                Name = "ProDHA Eye 1000 mg",
                ImageUrl = "http://www.rockwellnutrition.com/assets/images/nordic-natural-prodha-eye1000mg-60g.jpg",
                Ingredients = "purified deep sea fish oil (from anchovies and sardines), soft gel capsule (gelatin, purified water, glycerin, caramel color, natural lemon flavor), FloraGlo, lutein (in safflower oil), beeswax, d-alpha tocopherol, zeaxanthin (in corn oil), rosemary extract (a natural preservative).",
                Use = "Two soft gels daily, with food, or as directed by your health care professional or pharmacist Warning: Consult with your physician before using this product if you are allergic to iodine, use blood thinners, or anticipate surgery.",
                CreationDate = DateTime.Now.AddDays(Rand.Next(-5, 5))
            });
            Supplements.Add(new Supplement()
            {
                Category = Categories[1],
                Topic = Topics[4],
                Brand = Brands[1],
                Name = "Sero Plus",
                ImageUrl = "http://www.rockwellnutrition.com/assets/images/pure-encapsulations-sero-plus-120-caps.jpg",
                Ingredients = "Vitamin C (as ascorbic acid) 100 mg., Niacin(as niacinamide) 20 mg., Folate(as Metafolin®, L - 5 - MTHF) 500 mcg., Magnesium(as di - magnesium malate) 100 mg., Zinc(as zinc picolinate) 10 mg., 5 - hydroxytryptophan 100 mg., Inositol(as myo - inositol) 500 mg., Taurine(free - form) 200 mg., Pyridoxal 5' phosphate (activated B6) 10 mg.",
                Use = "Two capsules daily.",
                Description = "SeroPlus was developed by Pure Encapsulations in conjunction with Dr. James Greenblatt as part of The Integrative Mental Health Series, a line of products based on scientific findings as well as decades of clinical experience. SeroPlus provides neurotransmitter precursors to help balance serotonin function in the brain for emotional wellness, relaxation, moderating occasional stress, and maintaining healthy eating behavior. Also critical to each formulation in this series is the inclusion of a vitamin B6 , zinc and Metafolin® L-5-MTHF cofactor complex. These nutrients are often depleted in individuals due to medications, inadequate diets, and toxic environmental exposures, compromising the ability to properly synthesize neurotransmitters. When replete, these cofactors enhance neurotransmitter function and play a complementary role in supporting emotional wellness.",
                CreationDate = DateTime.Now.AddDays(Rand.Next(-5, 5))
            });
            Supplements.Add(new Supplement()
            {
                Category = Categories[2],
                Topic = Topics[1],
                Brand = Brands[2],
                Name = "Brain Shield",
                ImageUrl = "http://www.rockwellnutrition.com/assets/images/life-extension-brain-shield-60-vcaps.jpg",
                Ingredients = "Calcium (as dicalcium phosphate) 20 mg, Brain Shield Gastrodin 300 mg",
                Use = "Take one (1) capsule twice daily with or without food, or as recommended by a healthcare practitioner.",
                CreationDate = DateTime.Now.AddDays(Rand.Next(-5, 5))
            });
            Supplements.Add(new Supplement()
            {
                Category = Categories[3],
                Topic = Topics[0],
                Brand = Brands[1],
                Name = "Cardio-C",
                ImageUrl = "http://www.rockwellnutrition.com/assets/images/pure-encapsulations-cardiovascular-support-cardio-c-180-vcaps.jpg",
                Ingredients = "Vitamin C (as PureWay-C®) 270 mg., PhytoCardio proprietary blend 80 mg., providing wild blueberry(vaccinium angustifolium) extract(fruit), cran",
                Use = "Take one (1) capsule daily.",
                CreationDate = DateTime.Now.AddDays(Rand.Next(-5, 5))
            });
        }
    }
}
