import tkinter as tk
import sqlite3 as sql
import datetime as dt

conn = sql.connect("ClassroomNotificationSys.db")
crsr = conn.execute('''
    SELECT * FROM grades;
''')
for i in crsr:
    print(i)