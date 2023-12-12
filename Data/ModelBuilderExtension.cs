using Microsoft.EntityFrameworkCore;

namespace Railway_Group01.Data
{
    public static class ModelBuilderExtension
    {

        public static void Seed(this ModelBuilder builder)
        {
            TrainType F = new() { Code = "F", Name = "Fast Train" };
            TrainType S = new() { Code = "S", Name = "Slow Train" };
            TrainType SF = new() { Code = "SF", Name = "Super Fast Train" };
            builder.Entity<TrainType>().HasData(F, S, SF);

            Train SE1 = new() { Code = "SE1", TypeCode = F.Code };
            Train SE2 = new() { Code = "SE2", TypeCode = F.Code };
            Train SE3 = new() { Code = "SE3", TypeCode = SF.Code };
            Train SE4 = new() { Code = "SE4", TypeCode = SF.Code };
            Train SE5 = new() { Code = "SE5", TypeCode = S.Code };
            Train SE6 = new() { Code = "SE6", TypeCode = S.Code };
            List<Train> trainList = new() { SE1, SE2, SE3, SE4, SE5, SE6 };
            builder.Entity<Train>().HasData(trainList);

            CoachClass AC1 = new() { Code = "AC1", Name = "AC First Class" };
            CoachClass AC2 = new() { Code = "AC2", Name = "AC Second Class" };
            CoachClass AC3 = new() { Code = "AC3", Name = "AC Third Class" };
            CoachClass SL = new() { Code = "SL", Name = "Sleeper Class" };
            CoachClass GE = new() { Code = "GE", Name = "General Class" };
            builder.Entity<CoachClass>().HasData(AC1, AC2, AC3, SL, GE);

            List<Coach> coachList = new();
            var c = 1;
            foreach (var train in trainList)
            {
                Coach coach1 = new() { Id = c++, CoachNo = 1, TrainCode = train.Code, ClassCode = AC1.Code, NoOfCompartments = 7, NoOfSeats = 28 };
                Coach coach2 = new() { Id = c++, CoachNo = 2, TrainCode = train.Code, ClassCode = AC1.Code, NoOfCompartments = 7, NoOfSeats = 28 };
                Coach coach3 = new() { Id = c++, CoachNo = 3, TrainCode = train.Code, ClassCode = AC2.Code, NoOfCompartments = 7, NoOfSeats = 28 };
                Coach coach4 = new() { Id = c++, CoachNo = 4, TrainCode = train.Code, ClassCode = AC2.Code, NoOfCompartments = 7, NoOfSeats = 28 };
                Coach coach5 = new() { Id = c++, CoachNo = 5, TrainCode = train.Code, ClassCode = AC3.Code, NoOfCompartments = 7, NoOfSeats = 42 };
                Coach coach6 = new() { Id = c++, CoachNo = 6, TrainCode = train.Code, ClassCode = AC3.Code, NoOfCompartments = 7, NoOfSeats = 42 };
                Coach coach7 = new() { Id = c++, CoachNo = 7, TrainCode = train.Code, ClassCode = SL.Code, NoOfSeats = 32 };
                Coach coach8 = new() { Id = c++, CoachNo = 8, TrainCode = train.Code, ClassCode = SL.Code, NoOfSeats = 32 };
                Coach coach9 = new() { Id = c++, CoachNo = 9, TrainCode = train.Code, ClassCode = GE.Code, NoOfSeats = 62 };
                Coach coach10 = new() { Id = c++, CoachNo = 10, TrainCode = train.Code, ClassCode = GE.Code, NoOfSeats = 62 };
                coachList.Add(coach1);
                coachList.Add(coach2);
                coachList.Add(coach3);
                coachList.Add(coach4);
                coachList.Add(coach5);
                coachList.Add(coach6);
                coachList.Add(coach7);
                coachList.Add(coach8);
                coachList.Add(coach9);
                coachList.Add(coach10);
            }
            builder.Entity<Coach>().HasData(coachList);

            var k = 1;
            foreach (var coach in coachList)
            {
                var l = 1;
                if (coach.NoOfCompartments == 0)
                {
                    for (var i = 1; i <= coach.NoOfSeats; i++)
                    {
                        builder.Entity<Seat>().HasData(
                            new Seat { Id = k++, SeatNo = l++, CoachId = coach.Id, Available = false }
                            );
                    }
                }
                else
                {
                    var seatPerCompartment = coach.NoOfSeats / coach.NoOfCompartments;
                    for (var i = 1; i <= coach.NoOfCompartments; i++)
                    {
                        for (var j = 1; j <= seatPerCompartment; j++)
                        {
                            builder.Entity<Seat>().HasData(
                                new Seat { Id = k++, SeatNo = l++, CoachId = coach.Id, Available = false, CompartmentNo = i }
                                );
                        }
                    }
                }
            }

            Station SGO = new() { Id = 1, Code = "SGO", Name = "Sai Gon", NameOfDivision = "Ho Chi Minh City", Zone = 4 };
            Station BHO = new() { Id = 2, Code = "BHO", Name = "Bien Hoa", NameOfDivision = "Dong Nai Province", Zone = 4 };
            Station LKA = new() { Id = 3, Code = "LKA", Name = "Long Khanh", NameOfDivision = "Dong Nai Province", Zone = 4 };

            Station SKI = new() { Id = 4, Code = "SKI", Name = "Suoi Kiet", NameOfDivision = "Nam Binh Thuan Province", Zone = 3 };
            Station BTH = new() { Id = 5, Code = "SKI", Name = "Binh Thuan", NameOfDivision = "Binh Thuan Province", Zone = 3 };
            Station MLA = new() { Id = 6, Code = "MLA", Name = "Ma Lam", NameOfDivision = "Bac Binh Thuan Province", Zone = 3 };
            Station SMA = new() { Id = 7, Code = "SMA", Name = "Song Mao", NameOfDivision = "Bac Binh Thuan Province", Zone = 3 };
            Station TCH = new() { Id = 8, Code = "TCH", Name = "Thap Cham", NameOfDivision = "Cam Ranh Province", Zone = 3 };
            Station NBA = new() { Id = 9, Code = "NBA", Name = "Nga Ba", NameOfDivision = "Binh Thuan Province", Zone = 3 };
            Station NTR = new() { Id = 10, Code = "NTR", Name = "Nha Trang", NameOfDivision = "Khanh Hoa Province", Zone = 3 };
            Station NHO = new() { Id = 11, Code = "NHO", Name = "Ninh Hoa", NameOfDivision = "Khanh Hoa Province", Zone = 3 };
            Station VGI = new() { Id = 12, Code = "VGI", Name = "Van Gia", NameOfDivision = "Khanh Hoa Province", Zone = 3 };
            Station TYH = new() { Id = 13, Code = "TYH", Name = "Tuy Hoa", NameOfDivision = "Phu Yen Province", Zone = 3 };
            Station DTR = new() { Id = 14, Code = "DTR", Name = "Dieu Tri", NameOfDivision = "Binh Dinh Province", Zone = 3 };
            Station BSO = new() { Id = 15, Code = "BSO", Name = "Bong Son", NameOfDivision = "Binh Dinh Province", Zone = 3 };
            Station DPH = new() { Id = 16, Code = "DPH", Name = "Duc Pho", NameOfDivision = "Quang Ngai Province", Zone = 3 };
            Station QNG = new() { Id = 17, Code = "QNG", Name = "Quang Ngai", NameOfDivision = "Quang Ngai Province", Zone = 3 };
            Station NTH = new() { Id = 18, Code = "NTH", Name = "Nui Thanh", NameOfDivision = "Quang Nam Province", Zone = 3 };
            Station TKY = new() { Id = 19, Code = "TKY", Name = "Tam Ky", NameOfDivision = "Quang Nam Province", Zone = 3 };
            Station PCA = new() { Id = 20, Code = "PCA", Name = "Phu Cang", NameOfDivision = "Quang Nam Province", Zone = 3 };
            Station TKI = new() { Id = 21, Code = "TKI", Name = "Tra Kieu", NameOfDivision = "Quang Nam Province", Zone = 3 };
            Station DNA = new() { Id = 22, Code = "DNA", Name = "Da Nang", NameOfDivision = "Quang Nam Province", Zone = 3 };

            Station LCO = new() { Id = 23, Code = "LCO", Name = "Lang Co", NameOfDivision = "Thua Thien Hue Province", Zone = 2 };
            Station HUE = new() { Id = 24, Code = "HUE", Name = "Hue", NameOfDivision = "Thua Thien Hue Province", Zone = 2 };
            Station DHA = new() { Id = 25, Code = "DHA", Name = "Dong Ha", NameOfDivision = "Quang Tri Province", Zone = 2 };
            Station DHO = new() { Id = 26, Code = "DHO", Name = "Dong Hoi", NameOfDivision = "Quang Binh Province", Zone = 2 };
            Station DLE = new() { Id = 27, Code = "DLE", Name = "Dong Le", NameOfDivision = "Quang Binh Province", Zone = 2 };
            Station HPH = new() { Id = 28, Code = "HPH", Name = "Huong Pho", NameOfDivision = "Ha Tinh Province", Zone = 2 };
            Station YTR = new() { Id = 29, Code = "YTR", Name = "Yen Trung", NameOfDivision = "Ha Tinh Province", Zone = 2 };

            Station VIN = new() { Id = 30, Code = "VIN", Name = "Vinh", NameOfDivision = "Nghe An Province", Zone = 1 };
            Station CSY = new() { Id = 31, Code = "CSY", Name = "Cho Sy", NameOfDivision = "Nghe An Province", Zone = 1 };
            Station MKO = new() { Id = 32, Code = "MKO", Name = "Minh Khoi", NameOfDivision = "Nghe An Province", Zone = 1 };
            Station THO = new() { Id = 33, Code = "THO", Name = "Thanh Hoa", NameOfDivision = "Thanh Hoa Province", Zone = 1 };
            Station BIS = new() { Id = 34, Code = "BIS", Name = "Bim Son", NameOfDivision = "Thanh Hoa Province", Zone = 1 };
            Station NBI = new() { Id = 35, Code = "NBI", Name = "Ninh Binh", NameOfDivision = "Ninh Binh Province", Zone = 1 };
            Station NDI = new() { Id = 36, Code = "NDI", Name = "Nam Dinh", NameOfDivision = "Nam Dinh Province", Zone = 1 };
            Station PLY = new() { Id = 37, Code = "PLY", Name = "Phu Ly", NameOfDivision = "Ha Nam Province", Zone = 1 };
            Station HNO = new() { Id = 38, Code = "HNO", Name = "Ha Noi", NameOfDivision = "Hanoi Capital", Zone = 1 };
            List<Station> stationList = new() {
                SGO, BHO, LKA,
                SKI, BTH, MLA, SMA, TCH, NBA, NTR, NHO, VGI, TYH, DTR, BSO,DPH, QNG, NTH, TKY, PCA, TKI,
                DNA, LCO, HUE, DHA, DHO, DLE, HPH, YTR,
                VIN, CSY, MKO, THO, BIS, NBI, NDI, PLY, HNO
            };
            builder.Entity<Station>().HasData(stationList);



            builder.Entity<Route>().HasData(
                // Slow
                new Route { Id = 1, StartStationId = SGO.Id, EndStationId = HNO.Id, Distance = 1726 },
                new Route { Id = 2, StartStationId = HNO.Id, EndStationId = SGO.Id, Distance = 1726 },
                // Fast
                new Route { Id = 3, StartStationId = SGO.Id, EndStationId = HNO.Id, Distance = 1726 },
                new Route { Id = 4, StartStationId = HNO.Id, EndStationId = SGO.Id, Distance = 1726 },
                // Super Fast
                new Route { Id = 5, StartStationId = SGO.Id, EndStationId = HNO.Id, Distance = 1726 },
                new Route { Id = 6, StartStationId = HNO.Id, EndStationId = SGO.Id, Distance = 1726 }
                );

            var q = 1;
            builder.Entity<RouteDetail>().HasData(
                // SG-HN Slow
                new RouteDetail { Id = q++, DepartureStationId = SGO.Id, ArrivalStationId = SGO.Id, DelayTime = 0, Distance = 0, TravelTime = 0, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = SGO.Id, ArrivalStationId = BHO.Id, DelayTime = 5, Distance = 29, TravelTime = 40, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = BHO.Id, ArrivalStationId = LKA.Id, DelayTime = 5, Distance = 77, TravelTime = 76, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = LKA.Id, ArrivalStationId = SKI.Id, DelayTime = 5, Distance = 123, TravelTime = 46, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = SKI.Id, ArrivalStationId = BTH.Id, DelayTime = 5, Distance = 175, TravelTime = 67, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = BTH.Id, ArrivalStationId = MLA.Id, DelayTime = 5, Distance = 193, TravelTime = 23, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = MLA.Id, ArrivalStationId = SMA.Id, DelayTime = 5, Distance = 242, TravelTime = 46, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = SMA.Id, ArrivalStationId = TCH.Id, DelayTime = 5, Distance = 318, TravelTime = 78, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = TCH.Id, ArrivalStationId = NBA.Id, DelayTime = 5, Distance = 362, TravelTime = 56, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = NBA.Id, ArrivalStationId = NTR.Id, DelayTime = 5, Distance = 411, TravelTime = 45, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = NTR.Id, ArrivalStationId = NHO.Id, DelayTime = 5, Distance = 445, TravelTime = 59, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = NHO.Id, ArrivalStationId = VGI.Id, DelayTime = 5, Distance = 472, TravelTime = 29, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = VGI.Id, ArrivalStationId = TYH.Id, DelayTime = 5, Distance = 528, TravelTime = 62, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = TYH.Id, ArrivalStationId = DTR.Id, DelayTime = 5, Distance = 630, TravelTime = 98, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = DTR.Id, ArrivalStationId = BSO.Id, DelayTime = 5, Distance = 709, TravelTime = 96, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = BSO.Id, ArrivalStationId = DPH.Id, DelayTime = 5, Distance = 758, TravelTime = 48, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = DPH.Id, ArrivalStationId = QNG.Id, DelayTime = 5, Distance = 798, TravelTime = 56, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = QNG.Id, ArrivalStationId = NTH.Id, DelayTime = 5, Distance = 836, TravelTime = 41, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = NTH.Id, ArrivalStationId = TKY.Id, DelayTime = 5, Distance = 861, TravelTime = 27, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = TKY.Id, ArrivalStationId = PCA.Id, DelayTime = 5, Distance = 884, TravelTime = 23, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = PCA.Id, ArrivalStationId = TKI.Id, DelayTime = 5, Distance = 901, TravelTime = 15, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = TKI.Id, ArrivalStationId = DNA.Id, DelayTime = 5, Distance = 935, TravelTime = 54, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = DNA.Id, ArrivalStationId = LCO.Id, DelayTime = 5, Distance = 971, TravelTime = 89, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = LCO.Id, ArrivalStationId = HUE.Id, DelayTime = 5, Distance = 1038, TravelTime = 110, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = HUE.Id, ArrivalStationId = DHA.Id, DelayTime = 5, Distance = 1104, TravelTime = 103, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = DHA.Id, ArrivalStationId = DHO.Id, DelayTime = 5, Distance = 1204, TravelTime = 114, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = DHO.Id, ArrivalStationId = DLE.Id, DelayTime = 5, Distance = 1290, TravelTime = 73, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = DLE.Id, ArrivalStationId = HPH.Id, DelayTime = 5, Distance = 1339, TravelTime = 55, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = HPH.Id, ArrivalStationId = YTR.Id, DelayTime = 5, Distance = 1386, TravelTime = 31, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = YTR.Id, ArrivalStationId = VIN.Id, DelayTime = 5, Distance = 1407, TravelTime = 42, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = VIN.Id, ArrivalStationId = CSY.Id, DelayTime = 5, Distance = 1447, TravelTime = 79, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = CSY.Id, ArrivalStationId = MKO.Id, DelayTime = 5, Distance = 1529, TravelTime = 50, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = MKO.Id, ArrivalStationId = THO.Id, DelayTime = 5, Distance = 1551, TravelTime = 37, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = THO.Id, ArrivalStationId = BIS.Id, DelayTime = 5, Distance = 1585, TravelTime = 45, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = BIS.Id, ArrivalStationId = NBI.Id, DelayTime = 5, Distance = 1611, TravelTime = 32, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = NBI.Id, ArrivalStationId = NDI.Id, DelayTime = 5, Distance = 1639, TravelTime = 45, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = NDI.Id, ArrivalStationId = PLY.Id, DelayTime = 5, Distance = 1670, TravelTime = 45, RouteId = 1 },
                new RouteDetail { Id = q++, DepartureStationId = PLY.Id, ArrivalStationId = HNO.Id, DelayTime = 5, Distance = 1726, TravelTime = 67, RouteId = 1 },
                // HN-SG Slow
                new RouteDetail { Id = q++, DepartureStationId = HNO.Id, ArrivalStationId = HNO.Id, DelayTime = 0, Distance = 0, TravelTime = 0, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = HNO.Id, ArrivalStationId = PLY.Id, DelayTime = 5, Distance = 56, TravelTime = 67, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = PLY.Id, ArrivalStationId = NDI.Id, DelayTime = 5, Distance = 87, TravelTime = 45, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = NDI.Id, ArrivalStationId = NBI.Id, DelayTime = 5, Distance = 115, TravelTime = 42, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = NBI.Id, ArrivalStationId = BIS.Id, DelayTime = 5, Distance = 141, TravelTime = 32, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = BIS.Id, ArrivalStationId = THO.Id, DelayTime = 5, Distance = 175, TravelTime = 45, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = THO.Id, ArrivalStationId = MKO.Id, DelayTime = 5, Distance = 197, TravelTime = 37, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = MKO.Id, ArrivalStationId = CSY.Id, DelayTime = 5, Distance = 279, TravelTime = 50, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = CSY.Id, ArrivalStationId = VIN.Id, DelayTime = 5, Distance = 319, TravelTime = 79, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = VIN.Id, ArrivalStationId = YTR.Id, DelayTime = 5, Distance = 340, TravelTime = 42, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = YTR.Id, ArrivalStationId = HPH.Id, DelayTime = 5, Distance = 387, TravelTime = 31, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = HPH.Id, ArrivalStationId = DLE.Id, DelayTime = 5, Distance = 436, TravelTime = 55, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = DLE.Id, ArrivalStationId = DHO.Id, DelayTime = 5, Distance = 522, TravelTime = 73, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = DHO.Id, ArrivalStationId = DHA.Id, DelayTime = 5, Distance = 622, TravelTime = 114, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = DHA.Id, ArrivalStationId = HUE.Id, DelayTime = 5, Distance = 688, TravelTime = 103, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = HUE.Id, ArrivalStationId = LCO.Id, DelayTime = 5, Distance = 755, TravelTime = 110, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = LCO.Id, ArrivalStationId = DNA.Id, DelayTime = 5, Distance = 791, TravelTime = 89, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = DNA.Id, ArrivalStationId = TKI.Id, DelayTime = 5, Distance = 825, TravelTime = 54, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = TKI.Id, ArrivalStationId = PCA.Id, DelayTime = 5, Distance = 842, TravelTime = 15, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = PCA.Id, ArrivalStationId = TKY.Id, DelayTime = 5, Distance = 865, TravelTime = 23, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = TKY.Id, ArrivalStationId = NTH.Id, DelayTime = 5, Distance = 890, TravelTime = 27, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = NTH.Id, ArrivalStationId = QNG.Id, DelayTime = 5, Distance = 928, TravelTime = 41, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = QNG.Id, ArrivalStationId = DPH.Id, DelayTime = 5, Distance = 968, TravelTime = 56, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = DPH.Id, ArrivalStationId = BSO.Id, DelayTime = 5, Distance = 1017, TravelTime = 48, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = BSO.Id, ArrivalStationId = DTR.Id, DelayTime = 5, Distance = 1096, TravelTime = 96, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = DTR.Id, ArrivalStationId = TYH.Id, DelayTime = 5, Distance = 1198, TravelTime = 98, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = TYH.Id, ArrivalStationId = VGI.Id, DelayTime = 5, Distance = 1254, TravelTime = 62, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = VGI.Id, ArrivalStationId = NHO.Id, DelayTime = 5, Distance = 1281, TravelTime = 29, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = NHO.Id, ArrivalStationId = NTR.Id, DelayTime = 5, Distance = 1315, TravelTime = 59, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = NTR.Id, ArrivalStationId = NBA.Id, DelayTime = 5, Distance = 1364, TravelTime = 45, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = NBA.Id, ArrivalStationId = TCH.Id, DelayTime = 5, Distance = 1408, TravelTime = 56, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = TCH.Id, ArrivalStationId = SMA.Id, DelayTime = 5, Distance = 1484, TravelTime = 78, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = SMA.Id, ArrivalStationId = MLA.Id, DelayTime = 5, Distance = 1533, TravelTime = 46, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = MLA.Id, ArrivalStationId = BTH.Id, DelayTime = 5, Distance = 1551, TravelTime = 23, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = BTH.Id, ArrivalStationId = SKI.Id, DelayTime = 5, Distance = 1603, TravelTime = 67, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = SKI.Id, ArrivalStationId = LKA.Id, DelayTime = 5, Distance = 1649, TravelTime = 46, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = LKA.Id, ArrivalStationId = BHO.Id, DelayTime = 5, Distance = 1697, TravelTime = 76, RouteId = 2 },
                new RouteDetail { Id = q++, DepartureStationId = BHO.Id, ArrivalStationId = SGO.Id, DelayTime = 5, Distance = 1726, TravelTime = 40, RouteId = 2 },
                // SG-HN Fast
                new RouteDetail { Id = q++, DepartureStationId = SGO.Id, ArrivalStationId = SGO.Id, DelayTime = 0, Distance = 0, TravelTime = 0, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = SGO.Id, ArrivalStationId = BHO.Id, DelayTime = 5, Distance = 29, TravelTime = 38, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = BHO.Id, ArrivalStationId = BTH.Id, DelayTime = 5, Distance = 175, TravelTime = 147, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = BTH.Id, ArrivalStationId = TCH.Id, DelayTime = 5, Distance = 318, TravelTime = 126, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = TCH.Id, ArrivalStationId = NTR.Id, DelayTime = 5, Distance = 411, TravelTime = 88, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = NTR.Id, ArrivalStationId = TYH.Id, DelayTime = 5, Distance = 528, TravelTime = 110, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = TYH.Id, ArrivalStationId = DTR.Id, DelayTime = 5, Distance = 630, TravelTime = 95, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = DTR.Id, ArrivalStationId = QNG.Id, DelayTime = 5, Distance = 798, TravelTime = 95, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = QNG.Id, ArrivalStationId = TKY.Id, DelayTime = 5, Distance = 861, TravelTime = 60, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = TKY.Id, ArrivalStationId = DNA.Id, DelayTime = 5, Distance = 935, TravelTime = 68, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = DNA.Id, ArrivalStationId = HUE.Id, DelayTime = 5, Distance = 1038, TravelTime = 145, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = HUE.Id, ArrivalStationId = DHA.Id, DelayTime = 5, Distance = 1104, TravelTime = 70, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = DHA.Id, ArrivalStationId = DHO.Id, DelayTime = 5, Distance = 1204, TravelTime = 95, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = DHO.Id, ArrivalStationId = DLE.Id, DelayTime = 5, Distance = 1290, TravelTime = 153, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = DLE.Id, ArrivalStationId = HPH.Id, DelayTime = 5, Distance = 1339, TravelTime = 54, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = HPH.Id, ArrivalStationId = VIN.Id, DelayTime = 5, Distance = 1407, TravelTime = 25, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = VIN.Id, ArrivalStationId = THO.Id, DelayTime = 5, Distance = 1551, TravelTime = 132, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = THO.Id, ArrivalStationId = NBI.Id, DelayTime = 5, Distance = 1611, TravelTime = 60, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = NBI.Id, ArrivalStationId = NDI.Id, DelayTime = 5, Distance = 1639, TravelTime = 29, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = NDI.Id, ArrivalStationId = PLY.Id, DelayTime = 5, Distance = 1670, TravelTime = 31, RouteId = 3 },
                new RouteDetail { Id = q++, DepartureStationId = PLY.Id, ArrivalStationId = HNO.Id, DelayTime = 5, Distance = 1726, TravelTime = 62, RouteId = 3 },

                // HN-SG Fast
                new RouteDetail { Id = q++, DepartureStationId = HNO.Id, ArrivalStationId = HNO.Id, DelayTime = 0, Distance = 0, TravelTime = 0, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = HNO.Id, ArrivalStationId = PLY.Id, DelayTime = 5, Distance = 56, TravelTime = 62, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = PLY.Id, ArrivalStationId = NDI.Id, DelayTime = 5, Distance = 87, TravelTime = 76, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = NDI.Id, ArrivalStationId = THO.Id, DelayTime = 5, Distance = 175, TravelTime = 76, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = THO.Id, ArrivalStationId = VIN.Id, DelayTime = 5, Distance = 319, TravelTime = 132, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = VIN.Id, ArrivalStationId = YTR.Id, DelayTime = 5, Distance = 340, TravelTime = 25, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = YTR.Id, ArrivalStationId = HPH.Id, DelayTime = 5, Distance = 387, TravelTime = 54, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = HPH.Id, ArrivalStationId = DHO.Id, DelayTime = 5, Distance = 522, TravelTime = 153, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = DHO.Id, ArrivalStationId = DHA.Id, DelayTime = 5, Distance = 622, TravelTime = 95, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = DHA.Id, ArrivalStationId = HUE.Id, DelayTime = 5, Distance = 688, TravelTime = 70, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = HUE.Id, ArrivalStationId = DNA.Id, DelayTime = 5, Distance = 791, TravelTime = 145, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = DNA.Id, ArrivalStationId = TKY.Id, DelayTime = 5, Distance = 865, TravelTime = 68, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = TKY.Id, ArrivalStationId = QNG.Id, DelayTime = 5, Distance = 928, TravelTime = 60, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = QNG.Id, ArrivalStationId = DTR.Id, DelayTime = 5, Distance = 1096, TravelTime = 95, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = DTR.Id, ArrivalStationId = TYH.Id, DelayTime = 5, Distance = 1198, TravelTime = 95, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = TYH.Id, ArrivalStationId = NTR.Id, DelayTime = 5, Distance = 1315, TravelTime = 110, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = NTR.Id, ArrivalStationId = BTH.Id, DelayTime = 5, Distance = 1551, TravelTime = 246, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = BTH.Id, ArrivalStationId = BHO.Id, DelayTime = 5, Distance = 1697, TravelTime = 147, RouteId = 4 },
                new RouteDetail { Id = q++, DepartureStationId = BHO.Id, ArrivalStationId = SGO.Id, DelayTime = 5, Distance = 1726, TravelTime = 38, RouteId = 4 },
                // SG-HN SuperFast
                new RouteDetail { Id = q++, DepartureStationId = SGO.Id, ArrivalStationId = SGO.Id, DelayTime = 0, Distance = 0, TravelTime = 0, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = SGO.Id, ArrivalStationId = BHO.Id, DelayTime = 5, Distance = 29, TravelTime = 38, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = BHO.Id, ArrivalStationId = LKA.Id, DelayTime = 5, Distance = 77, TravelTime = 60, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = LKA.Id, ArrivalStationId = BTH.Id, DelayTime = 5, Distance = 175, TravelTime = 101, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = BTH.Id, ArrivalStationId = NTR.Id, DelayTime = 5, Distance = 411, TravelTime = 246, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = NTR.Id, ArrivalStationId = TYH.Id, DelayTime = 5, Distance = 528, TravelTime = 110, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = TYH.Id, ArrivalStationId = DTR.Id, DelayTime = 5, Distance = 630, TravelTime = 95, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = DTR.Id, ArrivalStationId = BSO.Id, DelayTime = 5, Distance = 709, TravelTime = 96, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = BSO.Id, ArrivalStationId = QNG.Id, DelayTime = 5, Distance = 798, TravelTime = 88, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = QNG.Id, ArrivalStationId = TKY.Id, DelayTime = 5, Distance = 861, TravelTime = 60, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = TKY.Id, ArrivalStationId = DNA.Id, DelayTime = 5, Distance = 935, TravelTime = 68, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = DNA.Id, ArrivalStationId = HUE.Id, DelayTime = 5, Distance = 1038, TravelTime = 145, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = HUE.Id, ArrivalStationId = DHA.Id, DelayTime = 5, Distance = 1104, TravelTime = 70, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = DHA.Id, ArrivalStationId = DHO.Id, DelayTime = 5, Distance = 1204, TravelTime = 95, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = DHO.Id, ArrivalStationId = DLE.Id, DelayTime = 5, Distance = 1290, TravelTime = 153, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = DLE.Id, ArrivalStationId = HPH.Id, DelayTime = 5, Distance = 1339, TravelTime = 54, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = HPH.Id, ArrivalStationId = YTR.Id, DelayTime = 5, Distance = 1386, TravelTime = 31, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = YTR.Id, ArrivalStationId = VIN.Id, DelayTime = 5, Distance = 1407, TravelTime = 42, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = VIN.Id, ArrivalStationId = THO.Id, DelayTime = 5, Distance = 1551, TravelTime = 132, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = THO.Id, ArrivalStationId = NDI.Id, DelayTime = 5, Distance = 1639, TravelTime = 96, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = NDI.Id, ArrivalStationId = PLY.Id, DelayTime = 5, Distance = 1670, TravelTime = 76, RouteId = 5 },
                new RouteDetail { Id = q++, DepartureStationId = PLY.Id, ArrivalStationId = HNO.Id, DelayTime = 5, Distance = 1726, TravelTime = 62, RouteId = 5 },
                // HN-SG SuperFast
                new RouteDetail { Id = q++, DepartureStationId = HNO.Id, ArrivalStationId = HNO.Id, DelayTime = 0, Distance = 0, TravelTime = 0, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = HNO.Id, ArrivalStationId = PLY.Id, DelayTime = 5, Distance = 56, TravelTime = 62, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = PLY.Id, ArrivalStationId = NDI.Id, DelayTime = 5, Distance = 87, TravelTime = 76, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = NDI.Id, ArrivalStationId = THO.Id, DelayTime = 5, Distance = 175, TravelTime = 96, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = THO.Id, ArrivalStationId = VIN.Id, DelayTime = 5, Distance = 319, TravelTime = 132, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = VIN.Id, ArrivalStationId = YTR.Id, DelayTime = 5, Distance = 340, TravelTime = 42, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = YTR.Id, ArrivalStationId = HPH.Id, DelayTime = 5, Distance = 387, TravelTime = 31, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = HPH.Id, ArrivalStationId = DHO.Id, DelayTime = 5, Distance = 522, TravelTime = 153, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = DHO.Id, ArrivalStationId = DHA.Id, DelayTime = 5, Distance = 622, TravelTime = 95, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = DHA.Id, ArrivalStationId = HUE.Id, DelayTime = 5, Distance = 688, TravelTime = 70, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = HUE.Id, ArrivalStationId = DNA.Id, DelayTime = 5, Distance = 791, TravelTime = 145, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = DNA.Id, ArrivalStationId = TKY.Id, DelayTime = 5, Distance = 865, TravelTime = 68, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = TKY.Id, ArrivalStationId = QNG.Id, DelayTime = 5, Distance = 928, TravelTime = 60, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = QNG.Id, ArrivalStationId = DTR.Id, DelayTime = 5, Distance = 1096, TravelTime = 95, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = DTR.Id, ArrivalStationId = TYH.Id, DelayTime = 5, Distance = 1198, TravelTime = 95, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = TYH.Id, ArrivalStationId = NTR.Id, DelayTime = 5, Distance = 1315, TravelTime = 110, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = NTR.Id, ArrivalStationId = BTH.Id, DelayTime = 5, Distance = 1551, TravelTime = 246, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = BTH.Id, ArrivalStationId = BHO.Id, DelayTime = 5, Distance = 1697, TravelTime = 147, RouteId = 6 },
                new RouteDetail { Id = q++, DepartureStationId = BHO.Id, ArrivalStationId = SGO.Id, DelayTime = 5, Distance = 1726, TravelTime = 38, RouteId = 6 }
                );


            var now = DateTime.Now;
            var hundredDaysBefore = now.Subtract(new TimeSpan(100, 0, 0, 0));
            var twoDays = new TimeSpan(2, 0, 0, 0);
            var twoThirdDay = new TimeSpan(8, 0, 0);

            var traveltime1 = new TimeSpan(31, 25, 0);
            var traveltime2 = new TimeSpan(33, 15, 0);
            var traveltime3 = new TimeSpan(33, 38, 0);

            var depart1 = hundredDaysBefore;
            var depart2 = depart1.Add(twoThirdDay);
            var depart3 = depart2.Add(twoThirdDay);

            var arrive1 = depart1.Add(traveltime1);
            var arrive2 = depart2.Add(traveltime2);
            var arrive3 = depart3.Add(traveltime3);


            var s = 1;
            for (var i = 0; i < 100; i++)
            {
                builder.Entity<Schedule>().HasData(
                    new Schedule { Id = s++, Name = "SE1 HN-SG Fast Train", TrainCode = SE1.Code, RouteId = 4, Departure = depart1, Arrival = arrive1 },
                    new Schedule { Id = s++, Name = "SE1 SG-HN Fast Train", TrainCode = SE1.Code, RouteId = 3, Departure = depart1.AddDays(1), Arrival = arrive1.AddDays(1) },

                    new Schedule { Id = s++, Name = "SE2 SG-HN Fast Train", TrainCode = SE2.Code, RouteId = 3, Departure = depart1, Arrival = arrive1 },
                    new Schedule { Id = s++, Name = "SE2 HN-SG Fast Train", TrainCode = SE2.Code, RouteId = 4, Departure = depart1.AddDays(1), Arrival = arrive1.AddDays(1) },

                    new Schedule { Id = s++, Name = "SE3 HN-SG Super Fast Train", TrainCode = SE3.Code, RouteId = 6, Departure = depart2, Arrival = arrive2 },
                    new Schedule { Id = s++, Name = "SE3 SG-HN Super Fast Train", TrainCode = SE3.Code, RouteId = 5, Departure = depart2.AddDays(1), Arrival = arrive2.AddDays(1) },

                    new Schedule { Id = s++, Name = "SE4 SG-HN Super Fast Train", TrainCode = SE4.Code, RouteId = 5, Departure = depart2, Arrival = arrive2 },
                    new Schedule { Id = s++, Name = "SE4 HN-SG Super Fast Train", TrainCode = SE4.Code, RouteId = 6, Departure = depart2.AddDays(1), Arrival = arrive2.AddDays(1) },

                    new Schedule { Id = s++, Name = "SE5 HN-SG Slow Train", TrainCode = SE5.Code, RouteId = 2, Departure = depart3, Arrival = arrive3 },
                    new Schedule { Id = s++, Name = "SE5 SG-HN Slow Train", TrainCode = SE5.Code, RouteId = 1, Departure = depart3.AddDays(1), Arrival = arrive3.AddDays(1) },

                    new Schedule { Id = s++, Name = "SE6 SG-HN Slow Train", TrainCode = SE6.Code, RouteId = 1, Departure = depart3, Arrival = arrive3 },
                    new Schedule { Id = s++, Name = "SE6 HN-SG Slow Train", TrainCode = SE6.Code, RouteId = 2, Departure = depart3.AddDays(1), Arrival = arrive3.AddDays(1) }
                    );
                hundredDaysBefore = hundredDaysBefore.Add(twoDays);
                depart1 = hundredDaysBefore;
                depart2 = depart1.Add(twoThirdDay);
                depart3 = depart2.Add(twoThirdDay);

                arrive1 = depart1.Add(traveltime1);
                arrive2 = depart2.Add(traveltime2);
                arrive3 = depart3.Add(traveltime3);
            }

            var f = 1;
            builder.Entity<Fare>().HasData(
                new Fare { Id = f++, RouteId = 1, ClassCode = "AC1", TypeCode = "S", Price = 100 },
                new Fare { Id = f++, RouteId = 1, ClassCode = "AC1", TypeCode = "F", Price = 110 },
                new Fare { Id = f++, RouteId = 1, ClassCode = "AC1", TypeCode = "SF", Price = 120 },
                new Fare { Id = f++, RouteId = 1, ClassCode = "AC2", TypeCode = "S", Price = 90 },
                new Fare { Id = f++, RouteId = 1, ClassCode = "AC2", TypeCode = "F", Price = 100 },
                new Fare { Id = f++, RouteId = 1, ClassCode = "AC2", TypeCode = "SF", Price = 110 },
                new Fare { Id = f++, RouteId = 1, ClassCode = "AC3", TypeCode = "S", Price = 80 },
                new Fare { Id = f++, RouteId = 1, ClassCode = "AC3", TypeCode = "F", Price = 90 },
                new Fare { Id = f++, RouteId = 1, ClassCode = "AC3", TypeCode = "SF", Price = 120 },
                new Fare { Id = f++, RouteId = 1, ClassCode = "SL", TypeCode = "S", Price = 70 },
                new Fare { Id = f++, RouteId = 1, ClassCode = "SL", TypeCode = "F", Price = 80 },
                new Fare { Id = f++, RouteId = 1, ClassCode = "SL", TypeCode = "SF", Price = 90 },
                new Fare { Id = f++, RouteId = 1, ClassCode = "GE", TypeCode = "S", Price = 60 },
                new Fare { Id = f++, RouteId = 1, ClassCode = "GE", TypeCode = "F", Price = 70 },
                new Fare { Id = f++, RouteId = 1, ClassCode = "GE", TypeCode = "SF", Price = 80 },

                new Fare { Id = f++, RouteId = 2, ClassCode = "AC1", TypeCode = "S", Price = 100 },
                new Fare { Id = f++, RouteId = 2, ClassCode = "AC1", TypeCode = "F", Price = 110 },
                new Fare { Id = f++, RouteId = 2, ClassCode = "AC1", TypeCode = "SF", Price = 120 },
                new Fare { Id = f++, RouteId = 2, ClassCode = "AC2", TypeCode = "S", Price = 90 },
                new Fare { Id = f++, RouteId = 2, ClassCode = "AC2", TypeCode = "F", Price = 100 },
                new Fare { Id = f++, RouteId = 2, ClassCode = "AC2", TypeCode = "SF", Price = 110 },
                new Fare { Id = f++, RouteId = 2, ClassCode = "AC3", TypeCode = "S", Price = 80 },
                new Fare { Id = f++, RouteId = 2, ClassCode = "AC3", TypeCode = "F", Price = 90 },
                new Fare { Id = f++, RouteId = 2, ClassCode = "AC3", TypeCode = "SF", Price = 100 },
                new Fare { Id = f++, RouteId = 2, ClassCode = "SL", TypeCode = "S", Price = 70 },
                new Fare { Id = f++, RouteId = 2, ClassCode = "SL", TypeCode = "F", Price = 80 },
                new Fare { Id = f++, RouteId = 2, ClassCode = "SL", TypeCode = "SF", Price = 90 },
                new Fare { Id = f++, RouteId = 2, ClassCode = "GE", TypeCode = "S", Price = 60 },
                new Fare { Id = f++, RouteId = 2, ClassCode = "GE", TypeCode = "F", Price = 70 },
                new Fare { Id = f++, RouteId = 2, ClassCode = "GE", TypeCode = "SF", Price = 80 }
                );

            builder.Entity<RefundRule>().HasData(
                new RefundRule { Id = 1, ValidTo = 24, RefundAmount = 100, RefundFee = 1 }, // above 24 hours till depart, refund 100%, fee 1$
                new RefundRule { Id = 2, ValidFrom = 24, ValidTo = 4, RefundAmount = 90, RefundFee = 0 }, // from 24 to 4 hours till depart, refund 90%
                new RefundRule { Id = 3, ValidFrom = 4, RefundAmount = 0, RefundFee = 0 } // from 4 hours to depart, no refund.
                );

            builder.Entity<PassengerType>().HasData(
                new PassengerType { Code = "CH", Name = "Child", Discount = 50 },
                new PassengerType { Code = "ST", Name = "Student", Discount = 10 },
                new PassengerType { Code = "AD", Name = "Adult", Discount = 0 },
                new PassengerType { Code = "ED", Name = "Elderly ", Discount = 10 }
                );
        }
    }
}
