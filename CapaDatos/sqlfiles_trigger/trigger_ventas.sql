        CREATE TRIGGER actualizar_totales_al_actualizar_ventas
        AFTER UPDATE OF Importe ON Pago_Cliente
        BEGIN
            UPDATE Totales
            SET Total_Ingreso = Total_Ingreso - OLD.Importe + NEW.Importe
            WHERE Anio = strftime('%Y', NEW.Fecha) AND Mes = strftime('%m', NEW.Fecha);
        END;
		
		
		
        CREATE TRIGGER actualizar_totales_al_eliminar_ventas
        AFTER DELETE ON Pago_Cliente
        BEGIN
            UPDATE Totales
            SET Total_Ingreso = Total_Ingreso - OLD.Importe
            WHERE Anio = strftime('%Y', OLD.Fecha) AND Mes = strftime('%m', OLD.Fecha);
        END;

		
		
        CREATE TRIGGER actualizar_totales_al_insertar_ventas
        AFTER INSERT ON Pago_Cliente
        BEGIN
            INSERT INTO Totales(Anio, Mes, Total_Ingreso)
            VALUES(strftime('%Y', NEW.Fecha), strftime('%m', NEW.Fecha), NEW.Importe)
            ON CONFLICT(Anio, Mes) DO UPDATE
            SET Total_Ingreso = Total_Ingreso + NEW.Importe;
        END;