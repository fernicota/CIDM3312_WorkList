using Microsoft.EntityFrameworkCore;

namespace CIDM3312_WorkList.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UserWorkDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<UserWorkDbContext>>()))
            {
                if (context.Users.Any())
                {
                    return; // DB has been seeded
                }
                
                var users = new []
                {
                    new User {Name = "Alexina Ockwell", Email = "aockwell0@jimdo.com", Age = 46, SkillLevel = "Level 7"},
                    new User {Name = "Bernice Linnett", Email = "blinnett1@opensource.org", Age = 24, SkillLevel = "level 8"},
                    new User {Name = "Linnet Nairy", Email = "lnairy2@w3.org", Age = 45, SkillLevel = "level 4"},
                    new User {Name = "Tucky Bavester", Email = "tbavester3@privacy.gov.au", Age = 31, SkillLevel = "Level 6"},
                    new User {Name = "Dannel Toderbrugge", Email = "dtoderbrugge4@jigsy.com", Age = 42, SkillLevel = "Level 1"},
                    new User {Name = "Bari Moakes", Email = "bmoakes5@php.net", Age = 29, SkillLevel = "Level 2"},
                    new User {Name = "Alissa Campana", Email = "acampana6@wordpress.com", Age = 29, SkillLevel = "Level 7"},
                    new User {Name = "Valma Bru", Email = "vbru7@cbsnews.com", Age = 27, SkillLevel = "level 5"},
                    new User {Name = "Maggee Pratten", Email = "mpratten8@clickbank.net", Age = 41, SkillLevel = "Level 7"},
                    new User {Name = "Riannon Hovert", Email = "rhovert9@bbc.co.uk", Age = 35, SkillLevel = "Level 8"},
                    new User {Name = "Lowe Angliss", Email = "langlissa@buzzfeed.com", Age = 24, SkillLevel = "Level 2"},
                    new User {Name = "Rozalin Postlethwaite", Email = "rpostlethwaiteb@webs.com", Age = 45, SkillLevel = "Level 4"},
                    new User {Name = "Gayelord Damrell", Email = "gdamrellc@umn.edu", Age = 36, SkillLevel = "level 5"},
                    new User {Name = "Palmer O'Day", Email = "podayd@latimes.com", Age = 22, SkillLevel = "level 6"},
                    new User {Name = "Harriott Sante", Email = "hsantee@sciencedaily.com", Age = 42, SkillLevel = "Level 8"},
                    new User {Name = "Bobbette Bene", Email = "bbenef@un.org", Age = 22, SkillLevel = "Level 1"},
                    new User {Name = "Bernadine Richarson", Email = "bricharsong@noaa.gov", Age = 41, SkillLevel = "Level 2"},
                    new User {Name = "Becki Maffini", Email = "bmaffinih@last.fm", Age = 36, SkillLevel = "Level 3"},
                    new User {Name = "Antony Dauney", Email = "adauneyi@ed.gov", Age = 32, SkillLevel = "Level 4"},
                    new User {Name = "Brendin Malzard", Email = "bmalzardj@columbia.edu", Age = 37, SkillLevel = "Level 5"},
                    new User {Name = "Hayes Jervoise", Email = "hjervoisek@mapquest.com", Age = 32, SkillLevel = "Level 4"},
                    new User {Name = "Nannie Halsho", Email = "nhalshol@w3.org", Age = 32, SkillLevel = "Level 2"},
                    new User {Name = "Garrett Gulberg", Email = "ggulbergm@pen.io", Age = 47, SkillLevel = "Level 4"},
                    new User {Name = "Alard Kordova", Email = "akordovan@thetimes.co.uk", Age = 25, SkillLevel = "Level 6"},
                    new User {Name = "Beniamino Babington", Email = "bbabingtono@uiuc.edu", Age = 41, SkillLevel = "level 6"},
                    new User {Name = "Helli Bonett", Email = "hbonettp@adobe.com", Age = 28, SkillLevel = "Level 3"},
                    new User {Name = "Krishna Alster", Email = "kalsterq@blogs.com", Age = 39, SkillLevel = "Level 7"},
                    new User {Name = "Taryn Whitlaw", Email = "twhitlawr@opera.com", Age = 40, SkillLevel = "Level 6"},
                };
                context.Users.AddRange(users);
                context.SaveChanges();

                // Add Organizations
                var works = new[]
                {
                    new Work {Name = "Daily Rounds Inspection", Description = "Do a daily walk around and make sure everything is operating normally.", DateCreated = new DateTime (2023, 11, 23), Duration = "1:00", UserId= users[0].UserId },
                    new Work {Name = "Battery Changes and Battery PMs", Description = "Change batteries on equipment as needed and check water level on batteries.", DateCreated = new DateTime (2023, 12, 1), Duration = "2:00", UserId= users[1].UserId},
                    new Work {Name = "Daily Monitor of Refrigeration System", Description = "Constantly check up on the system throughout the shift.", DateCreated = new DateTime (2023, 12, 5), Duration = ":30", UserId= users[1].UserId},
                    new Work {Name = "Maintenance Training", Description = "Use given time to continue level training.", DateCreated = new DateTime (2023, 12, 1), Duration = "3:00", UserId= users[0].UserId},
                    new Work {Name = "Monthly Safety Training", Description = "Complete the safety training for the month", DateCreated = new DateTime (2023, 11, 30), Duration = "2:00", UserId= users[2].UserId},
                    new Work {Name = "Daily Duties - Pre-shift stretches, put away tools, and complete paperwork", Description = "Do your daily duties.", DateCreated = new DateTime (2023, 12, 4), Duration = ":30", UserId= users[3].UserId},
                    new Work {Name = "Answer Radio Calls", Description = "Answer any radio calls throughout shift.", DateCreated = new DateTime (2023, 11, 26), Duration = "1:00", UserId= users[4].UserId},
                    new Work {Name = "Monthly Inverter PM", Description = "Make sure inverter is operating normally .", DateCreated = new DateTime (2023, 12, 1), Duration = "2:00", UserId= users[5].UserId},
                    new Work {Name = "Monthly PM on PR #43", Description = "Monthly PM of equipment, replace parts as needed, and grease/lube zerks.", DateCreated = new DateTime (2023, 12, 2), Duration = "1:30", UserId= users[6].UserId},
                    new Work {Name = "Monthly PM on HL #8", Description = "Monthly PM of equipment, replace parts as needed, and grease/lube zerks.", DateCreated = new DateTime (2023, 12, 1), Duration = "1:30", UserId= users[7].UserId},
                    new Work {Name = "Quarterly Inspection of Control Bank CB-9", Description = "Make sure everything is operating normally and check guages for the right pressures.", DateCreated = new DateTime (2024, 1, 30), Duration = ":15", UserId= users[8].UserId},
                    new Work {Name = "Quarterly Inspection of Control Bank 1B2", Description = "Make sure everything is operating normally and check guages for the right pressures.", DateCreated = new DateTime (2023, 12, 31), Duration = ":15", UserId= users[8].UserId},
                    new Work {Name = "Semi-annual inspection of Evaporator 3C1", Description = "Ensure unit is working properly, check blades for wear and make sure rotation is good.", DateCreated = new DateTime (2023, 11, 15), Duration = ":30", UserId= users[9].UserId},
                    new Work {Name = "Clean ice off mezzanine", Description = "Take necessary tools to remove ice of mezzanine and units.", DateCreated = new DateTime (2023, 12, 1), Duration = "4:00", UserId= users[10].UserId},
                    new Work {Name = "Clean Shop, battery room, engine room, and panel room", Description = "Clean area from debris and make sure tools are put away.", DateCreated = new DateTime (2023, 11, 28), Duration = ":30", UserId= users[11].UserId },
                    new Work {Name = "Mop battery room", Description = "Mop and clean the battery room.", DateCreated = new DateTime (2023, 12, 1), Duration = ":30", UserId= users[16].UserId},
                    new Work {Name = "Fix the Dock Light on Dock 4", Description = "Replace bulb or repair wires if broken on light.", DateCreated = new DateTime (2023, 11, 29), Duration = "2 hour", UserId= users[18].UserId},
                    new Work {Name = "Replace belt on fan 2 on Condenser 1", Description = "Put new belt on Condenser 1.", DateCreated = new DateTime (2023, 12, 5), Duration = "3:00", UserId= users[19].UserId},
                    new Work {Name = "Rebuild and replace motor on water pump 3", Description = "Remove motor and replace worn seals and gaskets and then replace.", DateCreated = new DateTime (2023, 11, 25), Duration = "2:00", UserId= users[20].UserId},
                    new Work {Name = "Work on getting Jamison Door back on track", Description = "Door is off track and needs to be put back on track.", DateCreated = new DateTime (2023, 12, 3), Duration = "2:00", UserId= users[21].UserId},
                    new Work {Name = "Daily Box Conveyer PM", Description = "Replace any  missing bands from rollers and grease as needed.", DateCreated = new DateTime (2023, 12, 20), Duration = "1:30", UserId= users[21].UserId},
                    new Work {Name = "Install new guards for racks in warehouse", Description = "Install the new guardds and remove the old ones.", DateCreated = new DateTime (2023, 12, 12), Duration = "2:00", UserId= users[24].UserId},
                    new Work {Name = "Drain oil from oil pots", Description = "Drain oil from ammonia pumps, make sure to have your respirator on hand.", DateCreated = new DateTime (2023, 12, 7), Duration = "1:30", UserId= users[5].UserId},
                    new Work {Name = "Semi-annual inspection of Evaporator 3E1", Description = "Make sure evaporator drain line is free from debris and is draining properly.", DateCreated = new DateTime (2023, 12, 5), Duration = ":30", UserId= users[14].UserId},
                    new Work {Name = "Monthly Wrap Machine PM", Description = "Make sure values on controller are at default settings, and grease/lube as needed", DateCreated = new DateTime (2023, 11, 29), Duration = "1:00", UserId= users[15].UserId},
                    new Work {Name = "Repair Dock Leveler", Description = "Make sure dock leveler raises lip when fully extended, repair as needed.", DateCreated = new DateTime (2023, 10, 6), Duration = "3:00",UserId= users[12].UserId},
                };
                context.Works.AddRange(works);
                context.SaveChanges();
            }
        }    
    }
}