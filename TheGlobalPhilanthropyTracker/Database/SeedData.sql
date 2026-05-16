INSERT INTO SECTORS (NAME, DESCRIPTION) VALUES 
('Healthcare', 'Providing medical supplies, vaccinations, and emergency health services.'),
('Ecology', 'Reforestation, clean water initiatives, and wildlife protection.'),
('Disaster Relief', 'Immediate response to natural disasters and humanitarian crises.'),
('Education', 'Building schools and providing digital literacy programs in rural areas.'),
('Poverty Alleviation', 'Micro-finance and vocational training for underserved communities.');

INSERT INTO VENDORS (COMPANY_NAME, CONTACT_NUMBER) VALUES 
('Global Med Supplies', '01012345678'),
('Eco-Solutions Ltd', '01198765432'),
('Rapid Response Gear', '01234567890'),
('Modern Build Co.', '01555554444'),
('Tech-For-All', '01000001111');

INSERT INTO SUPPORTERS (FIRSTNAME, LASTNAME, EMAIL) VALUES 
('Seif', 'Lashin', 'seif.l@tracker.com'),
('Ahmad', 'Amin', 'ahmad.a@tracker.com'),
('Jana', 'Hassan', 'jana.h@tracker.com'),
('Yara', 'Hegab', 'yara.h@tracker.com'),
('Rahma', 'Musa', 'rahma.m@tracker.com'),
('Omar', 'Zaki', 'omar.zaki@email.com'),
('Laila', 'Fouad', 'laila.f@email.com'),
('Kareem', 'Sami', 'kareem.s@email.com');

INSERT INTO INITIATIVES (SECTORID, TITLE, PRIMARY_OBJECTIVE, FUNDING_TARGET, START_DATE, END_DATE, IMPACT_SUMMARIES) VALUES 
(1, 'Vaccine Outreach 2026', 'Distribute 10,000 vaccines.', 50000.00, '2026-01-01', '2026-12-31', 'Ongoing health support.'),
(2, 'Amazon Reforestation', 'Planting 5,000 native trees.', 25000.00, '2026-03-15', '2027-03-15', 'Initial saplings planted.'),
(3, 'Tornado Relief Alpha', 'Emergency shelter for 500 families.', 100000.00, '2026-04-05', '2026-06-05', 'Shelters deployed.'),
(4, 'Rural Coding School', 'IT training for 200 students.', 15000.00, '2026-02-01', '2026-11-30', 'Laptops procured.'),
(5, 'Micro-Loan Fund X', 'Providing 100 small business loans.', 40000.00, '2026-04-10', '2027-04-10', 'Phase 1 funding complete.'),
(1, 'Mobile Clinics Delta', 'Daily medical checkups in remote areas.', 30000.00, '2025-01-01', '2026-04-20', 'Final reports being filed.');

INSERT INTO CONTRIBUTIONS (SUPPORTERID, INITIATIVEID, AMOUNT, TIMESTAMP) VALUES 
(1, 1, 5000.00, '2026-04-02 10:30:00'),
(1, 3, 2000.00, '2026-04-15 14:20:00'),
(2, 3, 15000.00, '2026-04-10 09:00:00'),
(3, 2, 3000.00, '2026-04-12 11:45:00'),
(4, 4, 1000.00, '2026-04-18 16:15:00'),
(5, 5, 500.00, '2026-04-25 12:00:00'),
(2, 5, 5000.00, '2026-04-28 15:30:00'),
(6, 1, 100.00, '2026-03-15 10:00:00'),
(7, 1, 250.00, '2026-04-05 08:30:00'),
(8, 3, 10000.00, '2026-04-22 17:00:00');

INSERT INTO EXPENDITURES (INITIATIVEID, VENDORID, AMOUNT_SPENT, DATE_SPENT) VALUES 
(1, 1, 12000.00, '2026-04-05'),
(2, 2, 4500.00, '2026-04-12'),
(4, 5, 2000.00, '2026-04-20'),
(5, 5, 5000.00, '2026-04-30'),
(1, 1, 500.00, '2026-03-25');