SELECT VEHICLE.LICNO,
  VEHICLE.MANUFACTURER,
  VEHICLE.MAKE,
  VEHICLE.MODEL,
  VEHICLE.YEAR,
  VEHICLE.COLOR,
  VEHICLE.PURCHASEDATE,
  CUSTOMER.LNAME,
  CUSTOMER.FNAME,
  CUSTOMER.HPHONE,
  CUSTOMER.WPHONE
FROM VEHICLE
INNER JOIN CUSTOMER
ON CUSTOMER.CUSTID         = VEHICLE.CUSTID
WHERE VEHICLE.PURCHASEDATE > '01-JAN-2015'
