        CREATE TRIGGER actualizar_totales_al_actualizar_gastos_generales
        AFTER UPDATE OF Importe_Total ON Gastos_Generales
        BEGIN
            UPDATE Totales
            SET Total_Gasto = Total_Gasto - OLD.Importe_Total + NEW.Importe_Total
            WHERE Anio = strftime('%Y', NEW.Fecha) AND Mes = strftime('%m', NEW.Fecha);
        END;
		
		
		
        CREATE TRIGGER actualizar_totales_al_eliminar_gastos_generales
        AFTER DELETE ON Gastos_Generales
        BEGIN
            UPDATE Totales
            SET Total_Gasto = Total_Gasto - OLD.Importe_Total
            WHERE Anio = strftime('%Y', OLD.Fecha) AND Mes = strftime('%m', OLD.Fecha);
        END;

		
		
        CREATE TRIGGER actualizar_totales_al_insertar_gastos_generales
        AFTER INSERT ON Gastos_Generales
        BEGIN
            INSERT INTO Totales(Anio, Mes, Total_Gasto)
            VALUES(strftime('%Y', NEW.Fecha), strftime('%m', NEW.Fecha), NEW.Importe_Total)
            ON CONFLICT(Anio, Mes) DO UPDATE
            SET Total_Gasto = Total_Gasto + NEW.Importe_Total;
        END;