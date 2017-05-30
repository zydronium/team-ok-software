insert into Locations (Address, City, Created, Deleted, Latitude, Longitude, Modified, Name, OpeningHours, Phonenumber, Postcode) values ('Daltonlaan 200', 'Utrecht', GETDATE(), 0, 52.0884244, 5.159922700000038, GETDATE(), 'Daltonlaan 200 (tijdelijke locatie)', 'maandag t/m vrijdag van 08:00 tot 20:00', '088 - 481 82 83', '3584 BJ');

insert into facilities (Created, Deleted, Modified, Name) values (GETDATE(), 0, GETDATE(), 'Cafetaria');
insert into facilities (Created, Deleted, Modified, Name) values (GETDATE(), 0, GETDATE(), 'Parkeermogelijkheden');

insert into LocationFacilities (Created, Deleted, FacilityID, LocationID, Modified, Value) values (GETDATE(), 0, 1, 1, GETDATE(), 'AANWEZIG');
insert into LocationFacilities (Created, Deleted, FacilityID, LocationID, Modified, Value) values (GETDATE(), 0, 2, 1, GETDATE(), 'Ja, er zijn voldoende parkeerplaatsen in de omgeving van het gebouw');

insert into Floors (Created, Deleted, LocationID, Modified, Name) values (GETDATE(), 0, 1, GETDATE(), 'Instituutsplein ICT');

insert into facilities (Created, Deleted, Modified, Name) values (GETDATE(), 0, GETDATE(), 'Dummy');

insert into FloorFacilities (Created, Deleted, FacilityID, FloorID, Modified, Value) values (GETDATE(), 0, 3, 1, GETDATE(), 'Een dummy facility');

insert into Workspaces(Claimed, ClaimedUntill, Created, Deleted, FloorID, MacAddress, Modified, Name) values (1, GETDATE(), GETDATE(), 0, 1, 'b8:27:eb:83:bd:fd', GETDATE(), 'Werkplek 1');

insert into facilities (Created, Deleted, Modified, Name) values (GETDATE(), 0, GETDATE(), 'Stopcontacten');
insert into facilities (Created, Deleted, Modified, Name) values (GETDATE(), 0, GETDATE(), 'Zitplaatsen');
insert into facilities (Created, Deleted, Modified, Name) values (GETDATE(), 0, GETDATE(), 'Tafels');

insert into WorkspaceFacilities (Created, Deleted, FacilityID, Modified, Value, WorkspaceID) values (GETDATE(), 0, 4, GETDATE(), 2, 1);
insert into WorkspaceFacilities (Created, Deleted, FacilityID, Modified, Value, WorkspaceID) values (GETDATE(), 0, 5, GETDATE(), 4, 1);
insert into WorkspaceFacilities (Created, Deleted, FacilityID, Modified, Value, WorkspaceID) values (GETDATE(), 0, 6, GETDATE(), 1, 1);

insert into Workspaces(Claimed, ClaimedUntill, Created, Deleted, FloorID, MacAddress, Modified, Name) values (0, GETDATE(), GETDATE(), 0, 1, 'b8:27:eb:99:c1:9e', GETDATE(), 'Werkplek 2');

insert into WorkspaceFacilities (Created, Deleted, FacilityID, Modified, Value, WorkspaceID) values (GETDATE(), 0, 4, GETDATE(), 2, 2);
insert into WorkspaceFacilities (Created, Deleted, FacilityID, Modified, Value, WorkspaceID) values (GETDATE(), 0, 5, GETDATE(), 4, 2);
insert into WorkspaceFacilities (Created, Deleted, FacilityID, Modified, Value, WorkspaceID) values (GETDATE(), 0, 6, GETDATE(), 1, 2);