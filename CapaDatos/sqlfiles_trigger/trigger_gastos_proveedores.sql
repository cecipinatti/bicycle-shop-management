        CREATE TRIGGER actualizar_totales_al_actualizar_gastos_proveedores
        AFTER UPDATE OF Importe ON Pago_Proveedor
        BEGIN
            UPDATE Totales
            SET Total_Gasto = Total_Gasto - OLD.Importe + NEW.Importe
            WHERE Anio = strftime('%Y', NEW.Fecha) AND Mes = strftime('%m', NEW.Fecha);
        END;
		
		
		
        CREATE TRIGGER actualizar_totales_al_eliminar_gastos_proveedores
        AFTER DELETE ON Pago_Proveedor
        BEGIN
            UPDATE Totales
            SET Total_Gasto = Total_Gasto - OLD.Importe
            WHERE Anio = strftime('%Y', OLD.Fecha) AND Mes = strftime('%m', OLD.Fecha);
        END;

		
		
        CREATE TRIGGER actualizar_totales_al_insertar_gastos_proveedores
        AFTER INSERT ON Pago_Proveedor
        BEGIN
            INSERT INTO Totales(Anio, Mes, Total_Gasto)
            VALUES(strftime('%Y', NEW.Fecha), strftime('%m', NEW.Fecha), NEW.Importe)
            ON CONFLICT(Anio, Mes) DO UPDATE
            SET Total_Gasto = Total_Gasto + NEW.Importe;
        END;