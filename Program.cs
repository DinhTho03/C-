namespace on_tap
{

    class program
    {
        static void Main(string[] agrs)
        {
            #region Category
            List<Category> Categorys = new List<Category>{
            new Category(){
                url  = " Dee'sEstate.png",
                name  = " home",
            },
            new Category(){
                name  = " rent",
            },
            new Category(){
               name  = " land",
            },
            new Category(){
               name  = " agent",
            },
            new Category(){
               name  = " contact us",
               btn = " get started"
            },

            };
            showCategory ShowCategory = new showCategory() { Categorys = Categorys };
            Console.WriteLine("category luc dau: ");
            ShowCategory.showCategorys();


            Console.WriteLine("\ncategory luc chinh sua: ");
            Categorys.Add(new Category(" about"));
            Categorys.RemoveAt(2);
            Categorys.Insert(3, new Category(" check"));
            // Categorys.Clear();
            ShowCategory.showCategorys();
            #endregion

            #region  banner
            List<banner> content = new List<banner>
            {
                //#region content line 1 

                new banner() {
                    title = "Helping you find the property of your dreams.",
                    paragraphs ="\nCreating quality urban lifestyles,building stronger communities",
                    url = "\nimage.png",
                    btn = "\nLearn More "
                }
                //#endregion
            };
            Contentofbanner ContentOfBanner = new Contentofbanner() { content = content };
            ContentOfBanner.showcontent();
            #endregion

            #region  section 
            List<Section2> searchSection = new List<Section2>{
                new Section2{
                    title = "Location",
                    content = "Lekki ",
                    icon = ":>",

                },
                new Section2{
                    title = "Max Price",
                    content = "$10,000  ",
                    icon = ":>",

                },
                new Section2{
                    title = "Property Type",
                    content = "Duplex  ",
                    icon = ":>",
                    btn = " search"

                }
            };

            Constentofsection2 callCommandVariable = new Constentofsection2() { searchSection = searchSection };
            callCommandVariable.showsection2();

            #endregion

            #region  a question
            List<Aquestion> question = new List<Aquestion>{
                new Aquestion {
                    title = "How it works",
                    paragraphs = "\nThis is how our products works "

                }
            };

            ShowAquestion result = new ShowAquestion() { question = question };
            result.Showde();
            #endregion

            #region  demo
            List<Demo> demos = new List<Demo>{
                    new Demo {
                        title = "\nFind Home ",
                        paragraphs = "\nOur properties are located at prime areas where by there won’t be problem with transportation  ",
                        icon = ":>"
                    },
                    new Demo {
                        title = "\nMake payments  ",
                        paragraphs = "\nOur estates comes with good network,portable water , 24hrs light and round the clock security.  ",
                        icon = ":>"

                    },
                    new Demo {
                        title = "\nMake it Official  ",
                        paragraphs = "\nWe have been in business for over 32 years,for client outside the country you can trust  us to deliver well.   ",
                        icon = ":>"

                    }
                };

            Showdemo show = new Showdemo() { demos = demos };
            show.showDemo();
            #endregion

            #region model
            List<Model> models = new List<Model>{
                new Model {
                    image = "image.png",
                    title = "\nWhy you should choose us.  ",
                    paragraphs = "\nCreating quality urban lifestyles,building stronger communities  ",
                    icon = "\n:>",
                    content = "World class",
                },
                new Model {
                    icon = ":>",
                    content = "Affordable"
                },
                new Model {
                    icon = ":>",
                    content = "Trusted"
                },
                new Model {
                    icon = ":>",
                    content = "Amenities"
                },



            };

            showModel result2 = new showModel() { models = models };
            result2.showofModel();
            #endregion

            #region introduct about tilte


            List<Introduct> introducts2 = new List<Introduct>{
                    new Introduct {
                        title = "\nOur Featured Properties.  ",
                        paragraphs = "\nOne of our biggest product to be featured and that has sold out the most.  ",

                    }
                };

            Showintroduct2 result3 = new Showintroduct2() { introducts2 = introducts2 };
            result3.showintroduct2();

        
        #endregion

            #region introduct about image
        List<Introducthouse2> introduct3 = new List<Introducthouse2>{
                    new Introducthouse2 {
                        title = "\nThe Palace  ",
                        paragraphs = "\nLekki,phase 2  ",
                        image = "image.png",
                        place = "\nDuplex",
                        price ="\n$2,000"
                    },
                    new Introducthouse2 {
                        title = "\nThe Palace  ",
                        paragraphs = "\nLekki,phase 2  ",
                        image = "image.png",
                        place = "\nDuplex",
                        price ="\n$2,000"
                    },
                    new Introducthouse2 {
                        title = "\nThe Palace  ",
                        paragraphs = "\nLekki,phase 2  ",
                        image = "image.png",
                        place = "\nDuplex",
                        price ="\n$2,000"
                    }
                };

        Showintroduct3 result4 = new Showintroduct3() { introducts3 = introduct3 };
        result4.showintroduct();


        #endregion

            #region proof
        List<Proof> proofs2 = new List<Proof>{
                            new Proof {
                                title = "\nTestimonials.  ",
                                paragraphs = "\nThis is what our client are saying  ",
                            }
                        };

        ShowProof result5 = new ShowProof() { proofs2 = proofs2 };


                    #endregion

            #region describe

                            List<Descrise> descrises = new List<Descrise>{
                            new Descrise {
                                title = "Testimonials.  ",
                                paragraphs = "\nThis is what our client are saying  ",
                                content = "\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Fames ut dictumst urna, lorem nibh. Pretium leo hendrerit interdum netus"
                            },
                            new Descrise {
                                title = "Testimonials.  ",
                                paragraphs = "\nThis is what our client are saying  ",
                                content = "\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Fames ut dictumst urna, lorem nibh. Pretium leo hendrerit interdum netus"
                            },
                            new Descrise {
                                title = "Testimonials.  ",
                                paragraphs = "\nThis is what our client are saying  ",
                                content = "\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Fames ut dictumst urna, lorem nibh. Pretium leo hendrerit interdum netus"
                            }
                        };

        Showdescrise result6 = new Showdescrise() { descrises = descrises };
        result6.showDescrise();
                    #endregion

            #region footer
                    List<footer> footers = new List<footer>{
                    new footer {
                        title = "Dee's Estate   ",
                        paragraphs = "\nSolution for easy and flexible house hunting.You can trust us anywhere through this platform   ",
                    },
                    new footer {
                        title = "\nProperty   ",
                        paragraphs = "\nLearning Modules  "
                    },
                    new footer {
                        paragraphs = "Partnership  "
                    },
                    new footer {
                        paragraphs = "Watch demo  "
                    },
                    new footer {
                        paragraphs = "Event   "
                    },

                    new footer {
                        title = "\nAbout   ",
                        paragraphs = "\nOur Company   "
                    },
                    new footer {
                        paragraphs = "career  "
                    },
                    new footer {
                        paragraphs = "Investors Relations  "
                    },
                    new footer {
                        paragraphs = "Social Impact    "
                            },

                            new footer {
                                title = "\nResources   ",
                                paragraphs = "\ncontact "
                            },
                            new footer{
                                paragraphs = "Give feedback  "
                            },
                            new footer{
                                paragraphs = "System status  "
                            },
                            new footer{
                                paragraphs = "Privacy   Policy  "
                            }

                        };

        Showfooter result7 = new Showfooter() { footers = footers };
        result7.showFooter();
                    #endregion

        }

    }
}
