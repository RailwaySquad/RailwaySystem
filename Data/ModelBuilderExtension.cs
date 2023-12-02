using Microsoft.EntityFrameworkCore;

namespace Railway_Group01.Data
{
    public static class ModelBuilderExtension
    {

        public static void Seed(this ModelBuilder builder)
        {
            //TrainType F = new() { Code = "F", Name = "Fast Train" };
            //TrainType S = new() { Code = "S", Name = "Slow Train" };
            //TrainType SF = new() { Code = "SF", Name = "Super Fast Train" };
            //builder.Entity<TrainType>().HasData(F, S, SF);

            //Train SE1 = new() { Code = "SE1", TypeCode = F.Code };
            //Train SE2 = new() { Code = "SE2", TypeCode = F.Code };
            //Train SE3 = new() { Code = "SE3", TypeCode = SF.Code };
            //Train SE4 = new() { Code = "SE4", TypeCode = SF.Code };
            //Train SE5 = new() { Code = "SE5", TypeCode = S.Code };
            //Train SE6 = new() { Code = "SE6", TypeCode = S.Code };
            //List<Train> trainList = new() { SE1, SE2, SE3, SE4, SE5, SE6 };
            //builder.Entity<Train>().HasData(trainList);

            //CoachClass AC1 = new() { Code = "AC1", Name = "AC First Class" };
            //CoachClass AC2 = new() { Code = "AC2", Name = "AC Second Class" };
            //CoachClass AC3 = new() { Code = "AC3", Name = "AC Third Class" };
            //CoachClass SL = new() { Code = "SL", Name = "Sleeper Class" };
            //CoachClass GE = new() { Code = "GE", Name = "General Class" };
            //builder.Entity<CoachClass>().HasData(AC1, AC2, AC3, SL, GE);

            //List<Coach> coachList = new();
            //var c = 1;
            //foreach (var train in trainList)
            //{
            //    Coach coach1 = new() { Id = c++, CoachNo = 1, TrainCode = train.Code, ClassCode = AC1.Code, NoOfCompartments = 7, NoOfSeats = 28 };
            //    Coach coach2 = new() { Id = c++, CoachNo = 2, TrainCode = train.Code, ClassCode = AC1.Code, NoOfCompartments = 7, NoOfSeats = 28 };
            //    Coach coach3 = new() { Id = c++, CoachNo = 3, TrainCode = train.Code, ClassCode = AC2.Code, NoOfCompartments = 7, NoOfSeats = 28 };
            //    Coach coach4 = new() { Id = c++, CoachNo = 4, TrainCode = train.Code, ClassCode = AC2.Code, NoOfCompartments = 7, NoOfSeats = 28 };
            //    Coach coach5 = new() { Id = c++, CoachNo = 5, TrainCode = train.Code, ClassCode = AC3.Code, NoOfCompartments = 7, NoOfSeats = 42 };
            //    Coach coach6 = new() { Id = c++, CoachNo = 6, TrainCode = train.Code, ClassCode = AC3.Code, NoOfCompartments = 7, NoOfSeats = 42 };
            //    Coach coach7 = new() { Id = c++, CoachNo = 7, TrainCode = train.Code, ClassCode = SL.Code, NoOfSeats = 32 };
            //    Coach coach8 = new() { Id = c++, CoachNo = 8, TrainCode = train.Code, ClassCode = SL.Code, NoOfSeats = 32 };
            //    Coach coach9 = new() { Id = c++, CoachNo = 9, TrainCode = train.Code, ClassCode = GE.Code, NoOfSeats = 62 };
            //    Coach coach10 = new() { Id = c++, CoachNo = 10, TrainCode = train.Code, ClassCode = GE.Code, NoOfSeats = 62 };
            //    coachList.Add(coach1);
            //    coachList.Add(coach2);
            //    coachList.Add(coach3);
            //    coachList.Add(coach4);
            //    coachList.Add(coach5);
            //    coachList.Add(coach6);
            //    coachList.Add(coach7);
            //    coachList.Add(coach8);
            //    coachList.Add(coach9);
            //    coachList.Add(coach10);
            //}
            //builder.Entity<Coach>().HasData(coachList);

            //var k = 1;
            //foreach (var coach in coachList)
            //{
            //    var l = 1;
            //    if (coach.NoOfCompartments == 0)
            //    {
            //        for (var i = 1; i <= coach.NoOfCompartments; i++)
            //        {
            //            builder.Entity<Seat>().HasData(
            //                new Seat { Id = k++, SeatNo = l++, CoachId = coach.Id, Available = false }
            //                );
            //        }
            //    }
            //    else
            //    {
            //        var seatPerCompartment = coach.NoOfSeats / coach.NoOfCompartments;
            //        for (var i = 1; i <= coach.NoOfCompartments; i++)
            //        {
            //            for (var j = 1; j <= seatPerCompartment; j++)
            //            {
            //                builder.Entity<Seat>().HasData(
            //                    new Seat { Id = k++, SeatNo = l++, CoachId = coach.Id, Available = false, CompartmentNo = i }
            //                    );
            //            }
            //        }
            //    }
            //}

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
                new Route { Id = 3, StartStationId = HNO.Id, EndStationId = SGO.Id, Distance = 1726 },
                new Route { Id = 4, StartStationId = HNO.Id, EndStationId = SGO.Id, Distance = 1726 },
                // Super Fast
                new Route { Id = 5, StartStationId = HNO.Id, EndStationId = SGO.Id, Distance = 1726 },
                new Route { Id = 6, StartStationId = HNO.Id, EndStationId = SGO.Id, Distance = 1726 }
                );

            builder.Entity<RouteDetail>().HasData(
                // SG-HN Slow
                new RouteDetail { Id = 1, DepartureStationId = SGO.Id, ArrivalStationId = SGO.Id, DelayTime = 0, Distance = 0, TravelTime = 0, RouteId = 1 },
                new RouteDetail { Id = 2, DepartureStationId = SGO.Id, ArrivalStationId = BHO.Id, DelayTime = 5, Distance = 29, TravelTime = 40, RouteId = 1 },
                new RouteDetail { Id = 3, DepartureStationId = BHO.Id, ArrivalStationId = LKA.Id, DelayTime = 5, Distance = 77, TravelTime = 76, RouteId = 1 },
                new RouteDetail { Id = 4, DepartureStationId = LKA.Id, ArrivalStationId = SKI.Id, DelayTime = 5, Distance = 123, TravelTime = 46, RouteId = 1 },
                new RouteDetail { Id = 5, DepartureStationId = SKI.Id, ArrivalStationId = BTH.Id, DelayTime = 5, Distance = 175, TravelTime = 67, RouteId = 1 },
                new RouteDetail { Id = 6, DepartureStationId = BTH.Id, ArrivalStationId = MLA.Id, DelayTime = 5, Distance = 193, TravelTime = 23, RouteId = 1 },
                new RouteDetail { Id = 7, DepartureStationId = MLA.Id, ArrivalStationId = SMA.Id, DelayTime = 5, Distance = 242, TravelTime = 46, RouteId = 1 },
                new RouteDetail { Id = 8, DepartureStationId = SMA.Id, ArrivalStationId = TCH.Id, DelayTime = 5, Distance = 318, TravelTime = 78, RouteId = 1 },
                new RouteDetail { Id = 9, DepartureStationId = TCH.Id, ArrivalStationId = NBA.Id, DelayTime = 5, Distance = 362, TravelTime = 56, RouteId = 1 },
                new RouteDetail { Id = 10, DepartureStationId = NBA.Id, ArrivalStationId = NTR.Id, DelayTime = 5, Distance = 411, TravelTime = 45, RouteId = 1 },
                new RouteDetail { Id = 11, DepartureStationId = NTR.Id, ArrivalStationId = NHO.Id, DelayTime = 5, Distance = 445, TravelTime = 59, RouteId = 1 },
                new RouteDetail { Id = 12, DepartureStationId = NHO.Id, ArrivalStationId = VGI.Id, DelayTime = 5, Distance = 472, TravelTime = 29, RouteId = 1 },
                new RouteDetail { Id = 13, DepartureStationId = VGI.Id, ArrivalStationId = TYH.Id, DelayTime = 5, Distance = 528, TravelTime = 62, RouteId = 1 },
                new RouteDetail { Id = 14, DepartureStationId = TYH.Id, ArrivalStationId = DTR.Id, DelayTime = 5, Distance = 630, TravelTime = 98, RouteId = 1 },
                new RouteDetail { Id = 15, DepartureStationId = DTR.Id, ArrivalStationId = BSO.Id, DelayTime = 5, Distance = 709, TravelTime = 96, RouteId = 1 },
                new RouteDetail { Id = 16, DepartureStationId = BSO.Id, ArrivalStationId = DPH.Id, DelayTime = 5, Distance = 758, TravelTime = 48, RouteId = 1 },
                new RouteDetail { Id = 17, DepartureStationId = DPH.Id, ArrivalStationId = QNG.Id, DelayTime = 5, Distance = 798, TravelTime = 56, RouteId = 1 },
                new RouteDetail { Id = 18, DepartureStationId = QNG.Id, ArrivalStationId = NTH.Id, DelayTime = 5, Distance = 836, TravelTime = 41, RouteId = 1 },
                new RouteDetail { Id = 19, DepartureStationId = NTH.Id, ArrivalStationId = TKY.Id, DelayTime = 5, Distance = 861, TravelTime = 27, RouteId = 1 },
                new RouteDetail { Id = 20, DepartureStationId = TKY.Id, ArrivalStationId = PCA.Id, DelayTime = 5, Distance = 884, TravelTime = 23, RouteId = 1 },
                new RouteDetail { Id = 21, DepartureStationId = PCA.Id, ArrivalStationId = TKI.Id, DelayTime = 5, Distance = 901, TravelTime = 15, RouteId = 1 },
                new RouteDetail { Id = 22, DepartureStationId = TKI.Id, ArrivalStationId = DNA.Id, DelayTime = 5, Distance = 935, TravelTime = 54, RouteId = 1 },
                new RouteDetail { Id = 23, DepartureStationId = DNA.Id, ArrivalStationId = LCO.Id, DelayTime = 5, Distance = 971, TravelTime = 89, RouteId = 1 },
                new RouteDetail { Id = 24, DepartureStationId = LCO.Id, ArrivalStationId = HUE.Id, DelayTime = 5, Distance = 1038, TravelTime = 110, RouteId = 1 },
                new RouteDetail { Id = 25, DepartureStationId = HUE.Id, ArrivalStationId = DHA.Id, DelayTime = 5, Distance = 1104, TravelTime = 103, RouteId = 1 },
                new RouteDetail { Id = 26, DepartureStationId = DHA.Id, ArrivalStationId = DHO.Id, DelayTime = 5, Distance = 1204, TravelTime = 114, RouteId = 1 },
                new RouteDetail { Id = 27, DepartureStationId = DHO.Id, ArrivalStationId = DLE.Id, DelayTime = 5, Distance = 1290, TravelTime = 73, RouteId = 1 },
                new RouteDetail { Id = 28, DepartureStationId = DLE.Id, ArrivalStationId = HPH.Id, DelayTime = 5, Distance = 1339, TravelTime = 55, RouteId = 1 },
                new RouteDetail { Id = 29, DepartureStationId = HPH.Id, ArrivalStationId = YTR.Id, DelayTime = 5, Distance = 1386, TravelTime = 31, RouteId = 1 },
                new RouteDetail { Id = 30, DepartureStationId = YTR.Id, ArrivalStationId = VIN.Id, DelayTime = 5, Distance = 1407, TravelTime = 42, RouteId = 1 },
                new RouteDetail { Id = 31, DepartureStationId = VIN.Id, ArrivalStationId = CSY.Id, DelayTime = 5, Distance = 1447, TravelTime = 79, RouteId = 1 },
                new RouteDetail { Id = 32, DepartureStationId = CSY.Id, ArrivalStationId = MKO.Id, DelayTime = 5, Distance = 1529, TravelTime = 50, RouteId = 1 },
                new RouteDetail { Id = 33, DepartureStationId = MKO.Id, ArrivalStationId = THO.Id, DelayTime = 5, Distance = 1551, TravelTime = 37, RouteId = 1 },
                new RouteDetail { Id = 34, DepartureStationId = THO.Id, ArrivalStationId = BIS.Id, DelayTime = 5, Distance = 1585, TravelTime = 45, RouteId = 1 },
                new RouteDetail { Id = 35, DepartureStationId = BIS.Id, ArrivalStationId = NBI.Id, DelayTime = 5, Distance = 1611, TravelTime = 32, RouteId = 1 },
                new RouteDetail { Id = 36, DepartureStationId = NBI.Id, ArrivalStationId = NDI.Id, DelayTime = 5, Distance = 1639, TravelTime = 45, RouteId = 1 },
                new RouteDetail { Id = 37, DepartureStationId = NDI.Id, ArrivalStationId = PLY.Id, DelayTime = 5, Distance = 1670, TravelTime = 45, RouteId = 1 },
                new RouteDetail { Id = 38, DepartureStationId = PLY.Id, ArrivalStationId = HNO.Id, DelayTime = 5, Distance = 1726, TravelTime = 67, RouteId = 1 },
                // HN-SG Slow
                new RouteDetail { Id = 39, DepartureStationId = HNO.Id, ArrivalStationId = HNO.Id, DelayTime = 0, Distance = 0, TravelTime = 0, RouteId = 2 },
                new RouteDetail { Id = 40, DepartureStationId = HNO.Id, ArrivalStationId = PLY.Id, DelayTime = 5, Distance = 56, TravelTime = 67, RouteId = 2 },
                new RouteDetail { Id = 41, DepartureStationId = PLY.Id, ArrivalStationId = NDI.Id, DelayTime = 5, Distance = 87, TravelTime = 45, RouteId = 2 },
                new RouteDetail { Id = 42, DepartureStationId = NDI.Id, ArrivalStationId = NBI.Id, DelayTime = 5, Distance = 115, TravelTime = 42, RouteId = 2 },
                new RouteDetail { Id = 43, DepartureStationId = NBI.Id, ArrivalStationId = BIS.Id, DelayTime = 5, Distance = 141, TravelTime = 32, RouteId = 2 },
                new RouteDetail { Id = 44, DepartureStationId = BIS.Id, ArrivalStationId = THO.Id, DelayTime = 5, Distance = 175, TravelTime = 45, RouteId = 2 },
                new RouteDetail { Id = 45, DepartureStationId = THO.Id, ArrivalStationId = MKO.Id, DelayTime = 5, Distance = 197, TravelTime = 37, RouteId = 2 },
                new RouteDetail { Id = 46, DepartureStationId = MKO.Id, ArrivalStationId = CSY.Id, DelayTime = 5, Distance = 279, TravelTime = 50, RouteId = 2 },
                new RouteDetail { Id = 47, DepartureStationId = CSY.Id, ArrivalStationId = VIN.Id, DelayTime = 5, Distance = 319, TravelTime = 79, RouteId = 2 },
                new RouteDetail { Id = 48, DepartureStationId = VIN.Id, ArrivalStationId = YTR.Id, DelayTime = 5, Distance = 340, TravelTime = 42, RouteId = 2 },
                new RouteDetail { Id = 49, DepartureStationId = YTR.Id, ArrivalStationId = HPH.Id, DelayTime = 5, Distance = 387, TravelTime = 31, RouteId = 2 },
                new RouteDetail { Id = 50, DepartureStationId = HPH.Id, ArrivalStationId = DLE.Id, DelayTime = 5, Distance = 436, TravelTime = 55, RouteId = 2 },
                new RouteDetail { Id = 51, DepartureStationId = DLE.Id, ArrivalStationId = DHO.Id, DelayTime = 5, Distance = 522, TravelTime = 73, RouteId = 2 },
                new RouteDetail { Id = 52, DepartureStationId = DHO.Id, ArrivalStationId = DHA.Id, DelayTime = 5, Distance = 622, TravelTime = 114, RouteId = 2 },
                new RouteDetail { Id = 53, DepartureStationId = DHA.Id, ArrivalStationId = HUE.Id, DelayTime = 5, Distance = 688, TravelTime = 103, RouteId = 2 },
                new RouteDetail { Id = 54, DepartureStationId = HUE.Id, ArrivalStationId = LCO.Id, DelayTime = 5, Distance = 755, TravelTime = 110, RouteId = 2 },
                new RouteDetail { Id = 55, DepartureStationId = LCO.Id, ArrivalStationId = DNA.Id, DelayTime = 5, Distance = 791, TravelTime = 89, RouteId = 2 },
                new RouteDetail { Id = 56, DepartureStationId = DNA.Id, ArrivalStationId = TKI.Id, DelayTime = 5, Distance = 825, TravelTime = 54, RouteId = 2 },
                new RouteDetail { Id = 57, DepartureStationId = TKI.Id, ArrivalStationId = PCA.Id, DelayTime = 5, Distance = 842, TravelTime = 15, RouteId = 2 },
                new RouteDetail { Id = 58, DepartureStationId = PCA.Id, ArrivalStationId = TKY.Id, DelayTime = 5, Distance = 865, TravelTime = 23, RouteId = 2 },
                new RouteDetail { Id = 59, DepartureStationId = TKY.Id, ArrivalStationId = NTH.Id, DelayTime = 5, Distance = 890, TravelTime = 27, RouteId = 2 },
                new RouteDetail { Id = 70, DepartureStationId = NTH.Id, ArrivalStationId = QNG.Id, DelayTime = 5, Distance = 928, TravelTime = 41, RouteId = 2 },
                new RouteDetail { Id = 61, DepartureStationId = QNG.Id, ArrivalStationId = DPH.Id, DelayTime = 5, Distance = 968, TravelTime = 56, RouteId = 2 },
                new RouteDetail { Id = 62, DepartureStationId = DPH.Id, ArrivalStationId = BSO.Id, DelayTime = 5, Distance = 1017, TravelTime = 48, RouteId = 2 },
                new RouteDetail { Id = 63, DepartureStationId = BSO.Id, ArrivalStationId = DTR.Id, DelayTime = 5, Distance = 1096, TravelTime = 96, RouteId = 2 },
                new RouteDetail { Id = 64, DepartureStationId = DTR.Id, ArrivalStationId = TYH.Id, DelayTime = 5, Distance = 1198, TravelTime = 98, RouteId = 2 },
                new RouteDetail { Id = 65, DepartureStationId = TYH.Id, ArrivalStationId = VGI.Id, DelayTime = 5, Distance = 1254, TravelTime = 62, RouteId = 2 },
                new RouteDetail { Id = 66, DepartureStationId = VGI.Id, ArrivalStationId = NHO.Id, DelayTime = 5, Distance = 1281, TravelTime = 29, RouteId = 2 },
                new RouteDetail { Id = 67, DepartureStationId = NHO.Id, ArrivalStationId = NTR.Id, DelayTime = 5, Distance = 1315, TravelTime = 59, RouteId = 2 },
                new RouteDetail { Id = 68, DepartureStationId = NTR.Id, ArrivalStationId = NBA.Id, DelayTime = 5, Distance = 1364, TravelTime = 45, RouteId = 2 },
                new RouteDetail { Id = 69, DepartureStationId = NBA.Id, ArrivalStationId = TCH.Id, DelayTime = 5, Distance = 1408, TravelTime = 56, RouteId = 2 },
                new RouteDetail { Id = 70, DepartureStationId = TCH.Id, ArrivalStationId = SMA.Id, DelayTime = 5, Distance = 1484, TravelTime = 78, RouteId = 2 },
                new RouteDetail { Id = 71, DepartureStationId = SMA.Id, ArrivalStationId = MLA.Id, DelayTime = 5, Distance = 1533, TravelTime = 46, RouteId = 2 },
                new RouteDetail { Id = 72, DepartureStationId = MLA.Id, ArrivalStationId = BTH.Id, DelayTime = 5, Distance = 1551, TravelTime = 23, RouteId = 2 },
                new RouteDetail { Id = 73, DepartureStationId = BTH.Id, ArrivalStationId = SKI.Id, DelayTime = 5, Distance = 1603, TravelTime = 67, RouteId = 2 },
                new RouteDetail { Id = 74, DepartureStationId = SKI.Id, ArrivalStationId = LKA.Id, DelayTime = 5, Distance = 1649, TravelTime = 46, RouteId = 2 },
                new RouteDetail { Id = 75, DepartureStationId = LKA.Id, ArrivalStationId = BHO.Id, DelayTime = 5, Distance = 1697, TravelTime = 76, RouteId = 2 },
                new RouteDetail { Id = 76, DepartureStationId = BHO.Id, ArrivalStationId = SGO.Id, DelayTime = 5, Distance = 1726, TravelTime = 40, RouteId = 2 }

                );
            //builder.Entity<Schedule>().HasData(
            //    //SG-NT-H-HN 1 ngayXP 2-12 SE801
            //    //SG-HN
            //    new Schedule { Id = 1, RouteId = 1, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 6, 0, 0), EndAt = new DateTime(2023, 12, 3, 18, 12, 0), Code = "SE801" },
            //    //SG-NT
            //    new Schedule { Id = 2, RouteId = 2, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 6, 0, 0), EndAt = new DateTime(2023, 12, 2, 8, 15, 0), Code = "SE801" },
            //    //NT-H
            //    new Schedule { Id = 3, RouteId = 3, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 8, 28, 0), EndAt = new DateTime(2023, 12, 2, 21, 0, 0), Code = "SE801" },
            //    //H-HN
            //    new Schedule { Id = 4, RouteId = 8, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 21, 12, 0), EndAt = new DateTime(2023, 12, 3, 18, 0, 0), Code = "SE801" },
            //    //SG-H
            //    new Schedule { Id = 5, RouteId = 4, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 6, 0, 0), EndAt = new DateTime(2023, 12, 2, 21, 0, 0), Code = "SE801" },
            //    //NT-HN
            //    new Schedule { Id = 6, RouteId = 6, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 8, 28, 0), EndAt = new DateTime(2023, 12, 3, 18, 0, 0), Code = "SE801" },
            //    //SG-NT-HN  ngayXP 2-12 SE202
            //    //SG-HN 
            //    new Schedule { Id = 7, RouteId = 9, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 14, 00, 0), EndAt = new DateTime(2023, 12, 4, 1, 30, 0), Code = "SE201" },
            //    //SG-NT
            //    new Schedule { Id = 8, RouteId = 2, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 14, 00, 0), EndAt = new DateTime(2023, 12, 2, 22, 15, 0), Code = "SE201" },
            //    //NT-HN
            //    new Schedule { Id = 9, RouteId = 7, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 22, 27, 0), EndAt = new DateTime(2023, 12, 4, 1, 30, 0), Code = "SE201" },
            //    //SG-H-HN ngayXP 3-12 SE401 
            //    //SG-HN
            //    new Schedule { Id = 10, RouteId = 10, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 3, 7, 30, 0), EndAt = new DateTime(2023, 12, 4, 16, 0, 0), Code = "SE401" },
            //    //SG-H
            //    new Schedule { Id = 11, RouteId = 5, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 3, 7, 30, 0), EndAt = new DateTime(2023, 12, 4, 3, 10, 0), Code = "SE401" },
            //    //H-HN
            //    new Schedule { Id = 12, RouteId = 8, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 4, 3, 25, 0), EndAt = new DateTime(2023, 12, 4, 16, 0, 0), Code = "SE401" },

            //    //HN-H-NT-SG ngayXP 2-12
            //    //HN-SG 
            //    new Schedule { Id = 13, RouteId = 11, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 7, 20, 0), EndAt = new DateTime(2023, 12, 3, 19, 20, 0), Code = "SE701" },
            //    //HN-H 
            //    new Schedule { Id = 14, RouteId = 12, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 7, 20, 0), EndAt = new DateTime(2023, 12, 2, 23, 0, 0), Code = "SE701" },
            //    //H-NT
            //    new Schedule { Id = 15, RouteId = 15, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 23, 13, 0), EndAt = new DateTime(2023, 12, 3, 12, 0, 0), Code = "SE701" },
            //    //NT-SG
            //    new Schedule { Id = 16, RouteId = 18, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 3, 12, 15, 0), EndAt = new DateTime(2023, 12, 3, 19, 20, 0), Code = "SE701" },
            //    //HN-NT
            //    new Schedule { Id = 17, RouteId = 13, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 7, 20, 0), EndAt = new DateTime(2023, 12, 3, 12, 0, 0), Code = "SE701" },
            //    //H-SG
            //    new Schedule { Id = 18, RouteId = 16, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 23, 13, 0), EndAt = new DateTime(2023, 12, 3, 19, 20, 0), Code = "SE701" },

            //    //HN-H-SG ngayXP 2-12 
            //    //HN-SG
            //    new Schedule { Id = 19, RouteId = 19, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 17, 20, 0), EndAt = new DateTime(2023, 12, 4, 1, 20, 0), Code = "SE301" },
            //    //HN-H
            //    new Schedule { Id = 20, RouteId = 12, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 2, 17, 20, 0), EndAt = new DateTime(2023, 12, 3, 7, 20, 0), Code = "SE301" },
            //    //H-SG
            //    new Schedule { Id = 21, RouteId = 17, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 3, 7, 34, 0), EndAt = new DateTime(2023, 12, 4, 1, 20, 0), Code = "SE301" },

            //    //HN-NT-SG ngay XP 3-12
            //    //HN-SG
            //    new Schedule { Id = 22, RouteId = 20, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 3, 9, 0, 0), EndAt = new DateTime(2023, 12, 4, 20, 13, 0), Code = "SE101" },
            //    //HN-NT
            //    new Schedule { Id = 23, RouteId = 14, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 3, 9, 0, 0), EndAt = new DateTime(2023, 12, 4, 12, 0, 0), Code = "SE101" },
            //    //NT-SG
            //    new Schedule { Id = 24, RouteId = 20, ScheduleCompleted = false, StartAt = new DateTime(2023, 12, 4, 12, 13, 0), EndAt = new DateTime(2023, 12, 4, 20, 0, 0), Code = "SE101" }
            //    );
            //builder.Entity<Fare>().HasData(
            //    new Fare { Id = 1, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC1", TypeOfTrain = "SF", Price = 30 },
            //    new Fare { Id = 2, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC2", TypeOfTrain = "SF", Price = 25 },
            //    new Fare { Id = 3, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC3", TypeOfTrain = "SF", Price = 20 },
            //    new Fare { Id = 4, RouteId = 1, DistanceRange = 12000, TypeOfClass = "SL", TypeOfTrain = "SF", Price = 10 },
            //    new Fare { Id = 5, RouteId = 1, DistanceRange = 12000, TypeOfClass = "GE", TypeOfTrain = "SF", Price = 5 },

            //    new Fare { Id = 6, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC1", TypeOfTrain = "F", Price = 27 },
            //    new Fare { Id = 7, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC2", TypeOfTrain = "F", Price = 20 },
            //    new Fare { Id = 8, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC3", TypeOfTrain = "F", Price = 15 },
            //    new Fare { Id = 9, RouteId = 1, DistanceRange = 12000, TypeOfClass = "SL", TypeOfTrain = "F", Price = 8 },
            //    new Fare { Id = 10, RouteId = 1, DistanceRange = 12000, TypeOfClass = "GE", TypeOfTrain = "F", Price = 4 },

            //    new Fare { Id = 11, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC1", TypeOfTrain = "S", Price = 25 },
            //    new Fare { Id = 12, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC2", TypeOfTrain = "S", Price = 18 },
            //    new Fare { Id = 13, RouteId = 1, DistanceRange = 12000, TypeOfClass = "AC3", TypeOfTrain = "S", Price = 12 },
            //    new Fare { Id = 14, RouteId = 1, DistanceRange = 12000, TypeOfClass = "SL", TypeOfTrain = "S", Price = 6 },
            //    new Fare { Id = 15, RouteId = 1, DistanceRange = 12000, TypeOfClass = "GE", TypeOfTrain = "S", Price = 3 },

            //    new Fare { Id = 16, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC1", TypeOfTrain = "SF", Price = 30 },
            //    new Fare { Id = 17, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC2", TypeOfTrain = "SF", Price = 35 },
            //    new Fare { Id = 18, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC3", TypeOfTrain = "SF", Price = 25 },
            //    new Fare { Id = 19, RouteId = 2, DistanceRange = 18000, TypeOfClass = "SL", TypeOfTrain = "SF", Price = 15 },
            //    new Fare { Id = 20, RouteId = 2, DistanceRange = 18000, TypeOfClass = "GE", TypeOfTrain = "SF", Price = 5.5 },

            //    new Fare { Id = 21, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC1", TypeOfTrain = "F", Price = 45 },
            //    new Fare { Id = 22, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC2", TypeOfTrain = "F", Price = 25 },
            //    new Fare { Id = 23, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC3", TypeOfTrain = "F", Price = 20 },
            //    new Fare { Id = 24, RouteId = 2, DistanceRange = 18000, TypeOfClass = "SL", TypeOfTrain = "F", Price = 8.5 },
            //    new Fare { Id = 25, RouteId = 2, DistanceRange = 18000, TypeOfClass = "GE", TypeOfTrain = "F", Price = 4.5 },

            //    new Fare { Id = 26, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC1", TypeOfTrain = "S", Price = 39 },
            //    new Fare { Id = 27, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC2", TypeOfTrain = "S", Price = 20 },
            //    new Fare { Id = 28, RouteId = 2, DistanceRange = 18000, TypeOfClass = "AC3", TypeOfTrain = "S", Price = 16 },
            //    new Fare { Id = 29, RouteId = 2, DistanceRange = 18000, TypeOfClass = "SL", TypeOfTrain = "S", Price = 6.5 },
            //    new Fare { Id = 30, RouteId = 2, DistanceRange = 18000, TypeOfClass = "GE", TypeOfTrain = "S", Price = 3.5 },

            //    new Fare { Id = 31, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC1", TypeOfTrain = "SF", Price = 50 },
            //    new Fare { Id = 32, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC2", TypeOfTrain = "SF", Price = 30 },
            //    new Fare { Id = 33, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC3", TypeOfTrain = "SF", Price = 20 },
            //    new Fare { Id = 34, RouteId = 3, DistanceRange = 12000, TypeOfClass = "SL", TypeOfTrain = "SF", Price = 10 },
            //    new Fare { Id = 35, RouteId = 3, DistanceRange = 12000, TypeOfClass = "GE", TypeOfTrain = "SF", Price = 5 },

            //    new Fare { Id = 36, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC1", TypeOfTrain = "F", Price = 40 },
            //    new Fare { Id = 37, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC2", TypeOfTrain = "F", Price = 20 },
            //    new Fare { Id = 38, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC3", TypeOfTrain = "F", Price = 15 },
            //    new Fare { Id = 39, RouteId = 3, DistanceRange = 12000, TypeOfClass = "SL", TypeOfTrain = "F", Price = 8 },
            //    new Fare { Id = 40, RouteId = 3, DistanceRange = 12000, TypeOfClass = "GE", TypeOfTrain = "F", Price = 4 },

            //    new Fare { Id = 41, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC1", TypeOfTrain = "S", Price = 36 },
            //    new Fare { Id = 42, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC2", TypeOfTrain = "S", Price = 18 },
            //    new Fare { Id = 43, RouteId = 3, DistanceRange = 12000, TypeOfClass = "AC3", TypeOfTrain = "S", Price = 12 },
            //    new Fare { Id = 44, RouteId = 3, DistanceRange = 12000, TypeOfClass = "SL", TypeOfTrain = "S", Price = 6 },
            //    new Fare { Id = 45, RouteId = 3, DistanceRange = 12000, TypeOfClass = "GE", TypeOfTrain = "S", Price = 3 },

            //    new Fare { Id = 46, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC1", TypeOfTrain = "SF", Price = 55 },
            //    new Fare { Id = 47, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC2", TypeOfTrain = "SF", Price = 35 },
            //    new Fare { Id = 48, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC3", TypeOfTrain = "SF", Price = 25 },
            //    new Fare { Id = 49, RouteId = 4, DistanceRange = 18000, TypeOfClass = "SL", TypeOfTrain = "SF", Price = 12 },
            //    new Fare { Id = 50, RouteId = 4, DistanceRange = 18000, TypeOfClass = "GE", TypeOfTrain = "SF", Price = 5.5 },

            //    new Fare { Id = 51, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC1", TypeOfTrain = "F", Price = 45 },
            //    new Fare { Id = 52, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC2", TypeOfTrain = "F", Price = 25 },
            //    new Fare { Id = 53, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC3", TypeOfTrain = "F", Price = 20 },
            //    new Fare { Id = 54, RouteId = 4, DistanceRange = 18000, TypeOfClass = "SL", TypeOfTrain = "F", Price = 8.5 },
            //    new Fare { Id = 55, RouteId = 4, DistanceRange = 18000, TypeOfClass = "GE", TypeOfTrain = "F", Price = 4.5 },

            //    new Fare { Id = 56, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC1", TypeOfTrain = "S", Price = 39 },
            //    new Fare { Id = 57, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC2", TypeOfTrain = "S", Price = 20 },
            //    new Fare { Id = 58, RouteId = 4, DistanceRange = 18000, TypeOfClass = "AC3", TypeOfTrain = "S", Price = 16 },
            //    new Fare { Id = 59, RouteId = 4, DistanceRange = 18000, TypeOfClass = "SL", TypeOfTrain = "S", Price = 6.5 },
            //    new Fare { Id = 60, RouteId = 4, DistanceRange = 18000, TypeOfClass = "GE", TypeOfTrain = "S", Price = 3.5 }
            //    );
        }
    }
}
