﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovelNest.Infrastructure.Migrations
{
    public partial class DatabaseSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "DatePublished", "ImageUrl", "Title", "ViewsCount" },
                values: new object[,]
                {
                    { 1, "Излезе ново издание на „Мъжете, които мразеха жените“ (превод: Неда Димова-Бренстрьом, 464 стр., цена: 18 лв., издателство Колибри), най-зашеметяващия трилър от началото на XXI век. Зрелищната корица е дело на Живко Петров. МИЛЕНИУМ е името на вестника, чийто съсобственик и отговорен редактор Микаел Блумквист е главен герой в едноименната трилър трилогия. Още с излизането си през 2005 г. трилогията постига феноменален световен успех. „Мъжeтe, които мразеха жените“, първата книга от поредицата, получава наградата „Стъклен ключ“ за най-добър скандинавски роман за 2005 г., а вторият, „Момичето, което си играеше с огъня“ – наградата за най-добър шведски криминален роман за 2006 г. До момента от трите книги са продадени над 86 милиона екземпляра. Богатият индустриалец Хенрик Вангер предлага на Микаел Блумквист едногодишен договор срещу огромен хонорар, ако успее да разгадае мистерията с изчезването на любимата му племенница Хариет. Блумквист е разследващ журналист, разкрил ред скандални случаи и несправедливо осъден за клевета заради написана от него изобличителна статия срещу могъщ шведски финансов магнат. Заедно със суперхакера Лисбет Саландер – млада, кльощава, татуирана жена, регистрирана като психопат, работеща в детективска агенция, попадат във водовъртеж от драматични изпитания, семейна омраза и финансови скандали.Трилогията МИЛЕНИУМ разказва за един свят на аморални финансови сделки, на екстремистки заговори и на изкривено правосъдие. Свят, в който ще разпознаете и недъзи на българския политически и обществен живот. Стиг Ларшон (1954-2004) е известен шведски журналист и писател, чиито разследвания изобличават антидемократичните, дясноекстремистките и расистките практики в обществото и медиите. Трилогията Милениум му носи изключителна популярност още с публикуването на Мъжете, които мразеха жените, който има две успешни екранизации – шведска и американска. Ларшон умира от сърдечна криза на петдесетгодишна възраст наскоро след като е предал на издателя криминалната си поредица „Милениум“ и не доживява нейното отпечатване. Носят се слухове, че смъртта му не е случайна и е свързана с дейността му на разследващ журналист. През декември 2013 г. шведското издателство „Норстед“ обяви, че Давид Лагеркранс ще продължи поредицата на Стиг Ларшон. Последва цяла трилогия, преплитаща политически скандали и властови игри на високо ниво с ДНК изследвания, хималайски експедиции, киберпрестъпления и организирана омраза в интернет.", new DateTime(2023, 4, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), "https://i0.wp.com/vevesti.bg/wp-content/uploads/2021/11/9089304680924850968250498290457.jpg?resize=678%2C509&ssl=1", "„Мъжете, които мразеха жените“ на Стиг Ларшон с ново издание", 0 },
                    { 2, "Във Великобритания копие от първото издание на „Хари Потър и магьосническият камък“ на Дж. К. Роулинг, лежало 26 години в шкаф под стълбите, беше продадено на търг, съобщава Derbyshire Times. Книгата беше продадена на 11 декември в Hansons Auctioneers в Дербишър за 55 100 паунда. В продължение на много години тя се пазила от 58-годишна жителка, която я купила през 1997 г. по време на пътуване със семейството си. В магазина детската книга се намирала в кошницата с намаления и се продавала само за 10 паунда. „Купих си книга за Хари Потър, когато никой не знаеше за него или неговия автор. Пътувахме с кола в Шотландските планини. Имаше кафе-книжарница на един далечен полуостров в края на пътя”, разказва жената. Тя също така отбеляза, че е успяла да договори книгата за осем паунда, тъй като нямала външна обложка. По време на пътуването всяка вечер британката четяла приказка на децата си. По-късно книгата била прибрана в килер, където се съхранявала доскоро. Книгата се съхранила в отлично състояние. Специалист от Hansons Auctioneers разкри, че това е много рядко първо издание с твърди корици на първия роман на Джоан Роулинг за Хари Потър. Бяха отпечатани общо 500 книги, 300 от тях бяха разпространени в библиотеките, а само 200 бяха пуснати в продажба. В момента само 19 книги от тази серия са известни на колекционерите. Те бяха продадени на търгове за суми от 17 500 до 69 000 британски лири. По-рано беше съобщено, че библиотекарката Джанет Такуел решила да продаде първите издания на книги за Хари Потър с автографи на авторката. Жената получава подписите на Джоан Роулинг през 1999 г., когато работи като учителка и водила децата си на среща с писателката.", new DateTime(2024, 2, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), "https://www.tialoto.bg/media/files/resized/article/615x348/7e2/ad7a2b33b135c4662c374a7a37a8d7e2-5580840.jpg", "Продадоха за 55 000 паунда книга за Хари Потър, трупала прах 26 години", 0 },
                    { 3, "От 17,30 часа в зала „Ахело“ на Гранд хотел и СПА Приморец – организатор на културния форум, своята нова книга „Бай Тошо“ ще представи писателят, сценарист, драматург и телевизионен водещ Иво Сиромахов. Четивото е с логото на Сиела и е забавна безмилостна сатира на абсурдните времена, в които живеем. „България в наши дни. След провала на всички марионетни партии, създадени от невидимите политически инженери, се е стигнало до тежка безизходица. Време е да бъде изваден последният коз. С помощта на модерните технологии един олигарх възкресява образа на Бай Тошо и го поставя начело на държавата. За да „оправи“ всичко… „ – гласи анотацията на книгата. Повече, заповядайте да научите лично от нейния автор Иво Сиромахов. Ще има разговори, книги, автографи.", new DateTime(2024, 2, 18, 19, 30, 0, 0, DateTimeKind.Unspecified), "https://www.burgasnews.com/wp-content/uploads/2023/10/ivo-siromahov.jpg", "Иво Сиромахов представя романа си „Бай Тошо“ днес в Бургас", 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "47e76325-6e99-448e-8b9b-e9d419c36ff4", "guest@gmail.com", false, false, null, "guest@gmail.com", "guest", "AQAAAAEAACcQAAAAEPpmcOiXHjUm1zUvOStwxXCdOgOLRI2n7hmrbQm19KYYBt7p2qD1ihsdHh96P21FPA==", null, false, "a3b3d52c-85aa-485f-a5c9-6b87e8dd7dcf", false, "Guest" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "e2ea31e1-057a-4bc2-9423-e1d60f4bedec", "publisher@gmail.com", false, false, null, "publisher@gmail.com", "publisher", "AQAAAAEAACcQAAAAEDppcqFRlfP+caSHmcmTtjxRmywLLHbSToP8mYxdKpAme2Ex+cU5yODS3tYIOc5RLg==", null, false, "f04aa454-e819-4307-8f10-e84b3746d291", false, "Publisher" }
                });

            migrationBuilder.InsertData(
                table: "BookStores",
                columns: new[] { "Id", "ClosingTime", "Contact", "ImageUrl", "Location", "Name", "OpeningTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), "0876536843", "https://adandcity.files.wordpress.com/2015/05/926.jpg", "София център, бул. „Витоша“ 60, 1463 София", "Ciela - Витоша", new DateTime(2024, 2, 28, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 2, 28, 19, 30, 0, 0, DateTimeKind.Unspecified), "0896236457", "https://i.helikon.bg/content/601/202304270903201726.jpg", "Пазарджик Център, ул. „Професор Асен Златаров“ 23, 4400 Пазарджик", "Helikon - Пазарджик", new DateTime(2024, 2, 28, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 2, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), "0892414935", "https://www.orangecenter.bg/media/extensa_shop/image/grand-mall-varna_1.jpg", "м. Къро, бул. „Цариградско шосе“ 115, 1000 София", "Orange - The Mall", new DateTime(2024, 2, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CoverTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Мека" },
                    { 2, "Твърда" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "EndDate", "ImageUrl", "Location", "StartDate", "Topic" },
                values: new object[,]
                {
                    { 1, "Успоредно с излизането на книгата „Етюд-и-те на София: 24 часа в града“ Иван Шишиев ще представи и изложба на площад „Славейков“. Тя може да бъде видяна между 5-и и 30-и септември, а на деня на София, 17-и септември любителите на фотографията, литературата и техните проявления през обектива на Иван ще могат да се срещнат с автора на място в 11 ч. ЗА КНИГАТА: В рамките на 200 страници читателят е едновременно наблюдател и главен участник в един софийски ден. Какво са 24 часа в големия град? Как времето и пространството се пречупват под звуците на трамваите и тишината на спрелите часовници? Защо нишките на вековете са се оплели в малките улици на столицата и къде има опасност да пропаднеш хилядолетия назад? Този път фотографът на „Етюд-и-те на София“ се насочва към тези въпроси и към това да покаже как се изживява едно денонощие в града. А времето в София тече по свои собствени правила. И за да го уловиш истински във фотография, трябва да ги познаваш. Тик-так...", new DateTime(2023, 9, 30, 23, 59, 0, 0, DateTimeKind.Unspecified), "https://www.colibri.bg/uploads/2023/09/shishiev_event3.jpg", "Площад Славейков, София", new DateTime(2023, 9, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), "ИЗЛОЖБА | Етюд-и-те на София: 24 часа в града" },
                    { 2, "Очакваме Ви на представяне на книгата на Алберт Бенбасат „Когато големите станат малки“ на 12 декември, вторник, от 18:30 ч. в Каза Либри (Casa Libri) на ул. Цар Асен 64. Със специалното участие на Тони Николов и Георги Цанков! Алберт Бенбасат (р. 1950 г.) e литературен историк, критик, публицист и издател; професор, преподавател във Факултета по журналистика и масова комуникация в Софийския университет „Св. Климент Охридски”. Автор е на 13 книги, сред които „Българската еротиада”, „Европеецът” Бай Ганю и светлият мит за Щастливеца”, „Печатни пространства и бели полета”, „Банкноти и мечти между кориците. Масова книга и масово книгоиздаване”, „Алиса в дигиталния свят. По въпроса за книгата през ХХІ век”. Редактор и издател на сп. „Критика” и Библиотека „Критика”, съставител и редактор на множество книги.", new DateTime(2023, 12, 12, 21, 30, 0, 0, DateTimeKind.Unspecified), "https://www.colibri.bg/uploads/2023/12/benbasat_event.jpg", "Каза Либри (Casa Libri), ул. Цар Асен", new DateTime(2023, 12, 12, 18, 30, 0, 0, DateTimeKind.Unspecified), "Представяне на книгата на Алберт Бенбасат „Когато големите станат малки“" },
                    { 3, "На 6 юни в 19:00 ч. Ви каним на премиера на „Произходът на тоталитаризма“ от Хана Арент. Очакваме Ви в Топлоцентрала, Сцена бар. Книгата „Произходът на тоталитаризма“ се издава за първи път на български език в нейната цялост и включва трите й основни части: Антисемитизмът, Империализмът, Тоталитаризмът. Това е най-ранният мащабен труд на Хана Арент, донесъл й международна известност. Още с публикуването му през 1951 г. той предизвиква широка дискусия в научните среди с интерпретациите, които са извън доминиращите парадигми.", new DateTime(2024, 6, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), "https://www.colibri.bg/uploads/2023/05/arendt_event.jpg", "Топлоцентрала, Сцена бар, София", new DateTime(2024, 6, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), "Хана Арент - Произходът на тоталитаризма | Премиера" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Поезия" },
                    { 2, "Мистерия" },
                    { 3, "Фентъзи" },
                    { 4, "Трилър" },
                    { 5, "Любов" },
                    { 6, "Класика" },
                    { 7, "Хорър" },
                    { 8, "Приключенски" },
                    { 9, "Биография" },
                    { 10, "Автобиография" },
                    { 11, "Криминален" },
                    { 12, "Хумористичен" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverTypeId", "Description", "GenreId", "ImageUrl", "Pages", "Price", "PublishingHouse", "Title", "YearPublished" },
                values: new object[,]
                {
                    { 1, "Лев Толстой", 2, "Ана Каренина, изглежда, има всичко: красива е, богата, омъжена е за влиятелен политик и обожава сина си. Но тя усеща, че животът й е пуст – до момента, в който среща елегантния офицер граф Вронски. В отчаян опит да открие смисъла в живота си, тя се противопоставя на традициите на обществото. И напуска съпруга и сина си, за да живее със своя любим. Заклеймена и изолирана, Ана все по-често се поддава на пристъпите си на ревност към Вронски. А това го отчуждава. Скоро младата жена се оказва неспособна да избяга от все по-безнадеждната ситуация.", 6, "https://www.ciela.com/media/catalog/product/cache/32bb0748c82325b02c55df3c2a9a9856/a/n/ana-karenina-lev-tolstoi-hermes-9789542619529.jpg", 832, 24.95m, "Hermes", "Ана Каренина", 1877 },
                    { 2, "Томас Харис", 1, "Вече познавате добре д-р Ханибал Лектър – изискан джентълмен, проницателен психолог и... да, изтънчен канибал. Седем години той е на свобода след бягството си от затвора, седем години под чужда самоличност разточително се наслаждава на живота в люлката на Ренесанса – Флоренция, и не убива почти никого. Звярът в него като че ли е заспал.Но има хора, които не са забравили за него, и това далеч не са само ФБР, които жадуват да го заловят отново. Извратен богаташ, осакатен жестоко от д-р Лектър, дава мило и драго да го залови жив, за да нахрани с него специална порода чудовищни прасета, селектирани за целта. Последният лов е започнал и този път самият ловец е плячката.На помощ ще му се притече не някой друг, а красивата агентка Кларис Старлинг, която от служител на закона се е превърнала в изкупителна жертва на системата. Агнетата в нея са замълчали, но думите на Лектър все така я вълнуват. И тя е готова да отговори на повика на гениалния психопат.След като в „Червения дракон“ и „Мълчанието на агнетата“ най-известният сериен убиец в световната литература показа на какво е способен, в „Ханибал“ историята му достига до своя епичен завършек, в който всички сметки ще бъдат разчистени.И ще остане само още една история за разказване – тази в „Ханибал Лектър: Зараждането на злото“, която описва създаването на едно обаятелно чудовище.", 11, "https://www.ciela.com/media/catalog/product/cache/32bb0748c82325b02c55df3c2a9a9856/_/-/_-_-_-_9789542838296_-_ciela.jpg", 488, 19.90m, "Ciela", "Ханибал", 1999 },
                    { 3, "Стиг Ларшон", 1, "Богатият индустриалец Хенрик Вангер предлага на Микаел Блумквист едногодишен договор срещу огромен хонорар, ако успее да разгадае мистерията с изчезването на любимата му племенница Хариет. Микаел Блумквист е разследващ журналист, разкрил ред скандални случаи и несправедливо осъден за клевета заради написана от него изобличителна статия срещу могъщ шведски финансов магнат. Заедно със суперхакера Лисбет Саландер – млада, кльощава, татуирана и регистрирана като психопатка, сега работеща в детективска агенция, попадат в кръговрат от динамични събития и драматични изпитания, в свят на семейна омраза и финансови скандали, в който бродят убийци-психопати.Трилогията с над 80 милиона читатели в света разказва за един действителен свят на аморални финансови сфери, на екстремистки заговори и на изкривено правосъдие. Асоциация „Българска книга“ и журналистическото жури присъждат специално отличие „Бронзов лъв“ 2010 за издание с най-широк обществен отзвук на издателство „Колибри“ за трилогията „МИЛЕНИУМ“ от Стиг Ларшон.", 11, "https://www.ciela.com/media/catalog/product/cache/32bb0748c82325b02c55df3c2a9a9856/m/i/millenium_1.jpg", 464, 16.00m, "Colibri", "Мъжете, които мразеха жените", 2005 },
                    { 4, "Джоджо Мойс", 1, "Двадесет и шест годишната Луиза Кларк е обикновено момиче, което харесва обикновения си живот. Лу живее със семейството си в малка къща в провинциално английско градче. Младата жена обожава работата си в местното кафене и ексцентричните дрехи. Тя е доволна от спокойния си живот, възнамерява да се омъжи за дългогодишния си приятел Патрик и да му роди куп деца.Светът ѝ се преобръща, когато неочаквано загубва работата си. Наред с безпаричието, безработицата я кара да се чувства безполезна. Лу полага неимоверни усилия да си намери нова работа, но няколко седмици във фабрика за обработка на пилета и верига за бързо хранене я довеждат до ръба на отчаянието. Затова, когато й предлагат да стане личен асистент на мъж с увреждания срещу добро заплащане, тя решава да опита. Тридесет и три годишният Уил Трейнър граби с пълни шепи от живота. Той обожава работата си, предизвикателствата и пътуванията, които непрекъснато му напомнят колко необятен е светът. Произшествие с мотор го приковава към инвалидна количка и превръща дните му в безрадостно съществуване.Две години по-късно Уил няма представа, че Лу ще стане част от живота му и ще го разтърси из основи. И двамата не подозират, че запознанството им ще ги промени завинаги...", 5, "https://cdn.ozone.bg/media/catalog/product/cache/1/image/a4e40ebdc3e371adff845072e1c73f37/a/z/6d3e59789317f6a5d3c5e6dffb38e9db/az-predi-teb-30.jpg", 408, 17.95m, "Hermes", "Аз преди теб", 2012 },
                    { 5, "Ане Франк", 2, "Необикновеният дневник, написан на тавана на една „задна къща“ в Амстердам, където 13-годишното момиче и нейното семейство прекарват две години, укриващи се от нацистите, получава своето заслужено място сред класиките на XX век. С „Дневникът на Ане Франк“ споменът за една от най-мрачните епохи в човешката история оживява отново в луксозно издание с твърди корици и в пълния си, нецензуриран вид. В най-мрачните времена на миналия век едно на пръв поглед обикновено момиче ден след ден създава своето любовно писмо към живота, младостта и надеждата, своето свидетелство за силата на човешкия дух. Ане Франк води дневник от 12 юни 1942 г. до 1 август 1944 г. Пише писмата единствено за себе си, докато през про­летта на 1944 г. не чува по радио „Оранж“ речта на образова­телния министър в изгнание Болкестейн. Той призовава след войната да се съберат и публикуват всички документи, свиде­телстващи за страданията на нидерландския народ по време на германската окупация.", 10, "https://www.ciela.com/media/catalog/product/cache/32bb0748c82325b02c55df3c2a9a9856/a/n/ane-frank-zadnata-kyshta-ciela-9789542827214.jpg", 312, 19.90m, "Ciela", "Дневникът на Ане Франк", 1947 }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, "dea12856-c198-4129-b3f3-b893d8395082" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "BookStores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookStores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookStores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.DeleteData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
