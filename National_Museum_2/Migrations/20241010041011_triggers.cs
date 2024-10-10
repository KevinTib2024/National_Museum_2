using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace National_Museum_2.Migrations
{
    /// <inheritdoc />
    public partial class Triggers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /// Trigger User
            migrationBuilder.Sql(@"
            CREATE OR ALTER TRIGGER trg_AuditUser
            ON[user]
            AFTER INSERT, UPDATE, DELETE
            AS
            BEGIN
                SET NOCOUNT ON;
            --If there are inserted or updated records
                IF EXISTS(SELECT* FROM inserted)
                BEGIN
                    INSERT INTO historicUser(user_Id, user_Type_Id, identificationType_Id, identificationNumber, names, lastNames, birthDate, contact, gender_Id, email, password, ModificationDate, ModicationBy)
                    SELECT i.userId, i.user_Type_IduserTypeId, i.identificationType_IdidentificationTypeId, i.identificationNumber, i.names, i.lastNames, i.birthDate, i.contact, i.gender_IdgenderId, i.email, i.password,
                        GETDATE(),
                           CASE
                               WHEN EXISTS(SELECT * FROM deleted) THEN 'UPDATE'
                               ELSE 'INSERT'
                           END
                    FROM inserted i;
            END

            -- If there are deleted records
            IF EXISTS(SELECT * FROM deleted)
                BEGIN
                    INSERT INTO historicUser(user_Id, user_Type_Id, identificationType_Id, identificationNumber, names, lastNames, birthDate, contact, gender_Id, email, password, ModificationDate, ModicationBy)
                    SELECT d.userId, d.user_Type_IduserTypeId, d.identificationType_IdidentificationTypeId, d.identificationNumber, d.names, d.lastNames, d.birthDate, d.contact, d.gender_IdgenderId, d.email, d.password, GETDATE(), 'DELETE'
                          FROM deleted d;
                END
            END;
            ");

            /// Trigger Ticket
            migrationBuilder.Sql(@"
            CREATE OR ALTER TRIGGER trg_AuditTicket
            ON[ticket]
            AFTER INSERT, UPDATE, DELETE
            AS
            BEGIN
                SET NOCOUNT ON;
            --If there are inserted or updated records
                IF EXISTS(SELECT* FROM inserted)
                BEGIN
                    INSERT INTO historicTickets(ticket_Id, user_Id, visitDate, ticketType_Id, paymentMethod_Id, employeeId, ticketXCollection_Id, ModificationDate, ModicationBy)
                    SELECT i.ticketId, i.user_IduserId, i.visitDate, i.ticketType_IdticketTypeId, i.paymentMethod_IdpaymentMethodId, i.employeeId, i.ticketXCollection_IdticketXCollectionId,
                        GETDATE(),
                           CASE
                               WHEN EXISTS(SELECT * FROM deleted) THEN 'UPDATE'
                               ELSE 'INSERT'
                           END
                    FROM inserted i;
            END

            -- If there are deleted records
            IF EXISTS(SELECT * FROM deleted)
                BEGIN
                    INSERT INTO historicTickets(ticket_Id, user_Id, visitDate, ticketType_Id, paymentMethod_Id, employeeId, ticketXCollection_Id, ModificationDate, ModicationBy)
                    SELECT d.ticketId, d.user_IduserId, d.visitDate, d.ticketType_IdticketTypeId, d.paymentMethod_IdpaymentMethodId, d.employeeId, d.ticketXCollection_IdticketXCollectionId, GETDATE(), 'DELETE'
                          FROM deleted d;
                END
            END;
            ");


            /// Trigger Maintenance
            migrationBuilder.Sql(@"
            CREATE OR ALTER TRIGGER trg_AuditMaintenance
            ON[maintenance]
            AFTER INSERT, UPDATE, DELETE
            AS
            BEGIN
                SET NOCOUNT ON;
            --If there are inserted or updated records
                IF EXISTS(SELECT* FROM inserted)
                BEGIN
                    INSERT INTO historicMaintenance(maintenance_Id, artObject_Id, starDate, endDate, description, cost, ModificationDate, ModicationBy)
                    SELECT i.maintenanceId, i.artObject_IdartObjectId, i.starDate, i.endDate, i.description, i.cost,
                        GETDATE(),
                           CASE
                               WHEN EXISTS(SELECT * FROM deleted) THEN 'UPDATE'
                               ELSE 'INSERT'
                           END
                    FROM inserted i;
            END

            -- If there are deleted records
            IF EXISTS(SELECT * FROM deleted)
                BEGIN
                    INSERT INTO historicMaintenance( maintenance_Id, artObject_Id, starDate, endDate, description, cost, ModificationDate, ModicationBy)
                    SELECT d.maintenanceId, d.artObject_IdartObjectId, d.starDate, d.endDate, d.description, d.cost, GETDATE(), 'DELETE'
                          FROM deleted d;
                END
            END;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP TRIGGER IF EXISTS trg_AuditUser;");
            migrationBuilder.Sql("DROP TRIGGER IF EXISTS trg_AuditTicket;");
            migrationBuilder.Sql("DROP TRIGGER IF EXISTS trg_AuditMaintenance;");
        }
    }
}
