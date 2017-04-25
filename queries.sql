insert into Locations (Address, City, Created, Deleted, Latitude, Longitude, Modified, Name, OpeningHours, Phonenumber, Postcode) values ('Daltonlaan 200', 'Utrecht', GETDATE(), 0, 52.0884244, 5.159922700000038, GETDATE(), 'Daltonlaan 200 (tijdelijke locatie)', 'maandag t/m vrijdag van 08:00 tot 20:00', '088 - 481 82 83', '3584 BJ');

insert into facilities (Created, Deleted, Modified, Name) values (GETDATE(), 0, GETDATE(), 'Cafetaria');
insert into facilities (Created, Deleted, Modified, Name) values (GETDATE(), 0, GETDATE(), 'Parkeermogelijkheden');

insert into LocationFacilities (Created, Deleted, FacilityID, LocationID, Modified, Value) values (GETDATE(), 0, 1, 1, GETDATE(), 'AANWEZIG');
insert into LocationFacilities (Created, Deleted, FacilityID, LocationID, Modified, Value) values (GETDATE(), 0, 2, 1, GETDATE(), 'Ja, er zijn voldoende parkeerplaatsen in de omgeving van het gebouw');