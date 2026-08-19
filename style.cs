/* =====================================
   BASIC SETTINGS
===================================== */

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

html {
    scroll-behavior: smooth;
}

body {
    font-family: Arial, sans-serif;
    background: #faf8ff;
    color: #25213a;
    line-height: 1.6;
    transition: 0.4s;
}

a {
    text-decoration: none;
}

button {
    font-family: Arial, sans-serif;
    cursor: pointer;
}


/* =====================================
   NAVIGATION
===================================== */

header {
    position: sticky;
    top: 0;
    z-index: 1000;

    background: white;

    border-bottom: 1px solid #eee7ff;
}

nav {
    max-width: 1200px;
    margin: auto;

    padding: 18px 30px;

    display: flex;
    align-items: center;
    justify-content: space-between;
}

.logo {
    font-size: 26px;
    font-weight: bold;
}

.logo span {
    color: #8b5cf6;
}

.nav-links {
    display: flex;
    gap: 25px;
}

.nav-links a {
    color: #55506b;
    font-size: 14px;
    font-weight: bold;

    transition: 0.3s;
}

.nav-links a:hover {
    color: #8b5cf6;
}

#themeButton {
    width: 42px;
    height: 42px;

    border: none;
    border-radius: 50%;

    background: #f0eaff;

    font-size: 18px;
}


/* =====================================
   HOME
===================================== */

.home {
    min-height: 90vh;

    padding: 70px 8%;

    display: flex;
    align-items: center;

    background:
        radial-gradient(
            circle at 80% 20%,
            #e7ddff,
            transparent 30%
        ),
        radial-gradient(
            circle at 10% 80%,
            #dff8ff,
            transparent 30%
        );
}

.home-content {
    max-width: 1200px;
    width: 100%;

    margin: auto;

    display: flex;
    align-items: center;
    justify-content: space-between;

    gap: 50px;
}

.home-text {
    max-width: 600px;
}

.hello {
    color: #8b5cf6;

    font-size: 14px;
    font-weight: bold;

    letter-spacing: 3px;
}

.home h1 {
    font-size: 65px;

    line-height: 1.1;

    margin: 10px 0;
}

.home h1 span {
    color: #8b5cf6;
}

.home h2 {
    font-size: 27px;
    color: #514b68;
}

.intro {
    margin: 20px 0;

    color: #77718b;

    max-width: 550px;
}


/* BUTTONS */

.buttons {
    display: flex;
    gap: 15px;

    margin: 25px 0;
}

.primary-button,
.secondary-button {
    padding: 12px 20px;

    border-radius: 25px;

    font-weight: bold;

    transition: 0.3s;
}

.primary-button {
    background: #8b5cf6;
    color: white;

    box-shadow: 0 8px 20px #d0c2f5;
}

.primary-button:hover {
    transform: translateY(-4px);
}

.secondary-button {
    border: 2px solid #8b5cf6;
    color: #8b5cf6;
}

.secondary-button:hover {
    background: #8b5cf6;
    color: white;
}

.hello-button {
    background: transparent;
    border: none;

    color: #8b5cf6;

    font-weight: bold;
}

#greeting {
    color: #8b5cf6;
    font-weight: bold;

    margin-top: 10px;
}


/* =====================================
   PHOTO
===================================== */

.photo-area {
    width: 390px;
    height: 390px;

    position: relative;

    display: flex;
    align-items: center;
    justify-content: center;
}

.circle-background {
    position: absolute;

    width: 350px;
    height: 350px;

    border-radius: 50%;

    background:
        linear-gradient(
            135deg,
            #c4b5fd,
            #67e8f9
        );

    opacity: 0.8;
}

.photo-container {
    width: 310px;
    height: 310px;

    padding: 8px;

    position: relative;
    z-index: 2;

    background: white;

    border-radius: 50%;

    box-shadow: 0 15px 40px #cfc6df;
}

.photo-container img {
    width: 100%;
    height: 100%;

    object-fit: cover;

    border-radius: 50%;
}

.photo-label {
    position: absolute;

    bottom: 25px;
    left: 0;

    z-index: 3;

    background: white;

    padding: 10px 16px;

    border-radius: 20px;

    font-size: 12px;
    font-weight: bold;

    box-shadow: 0 8px 20px #d8d0e5;
}


/* =====================================
   SECTION
===================================== */

.section {
    padding: 90px 8%;
}

.heading {
    text-align: center;

    margin-bottom: 45px;
}

.heading p {
    color: #8b5cf6;

    font-size: 12px;
    font-weight: bold;

    letter-spacing: 3px;
}

.heading h2 {
    font-size: 40px;

    margin-top: 5px;
}

.heading h2 span {
    color: #8b5cf6;
}


/* =====================================
   ABOUT
===================================== */

.about-container {
    max-width: 1100px;
    margin: auto;

    display: flex;

    gap: 20px;
}

.about-small,
.about-main {
    background: white;

    border: 1px solid #eee8ff;

    border-radius: 20px;

    padding: 30px;

    box-shadow: 0 8px 25px #ebe5f5;

    transition: 0.3s;
}

.about-small {
    flex: 1;
}

.about-main {
    flex: 2;
}

.about-small:hover,
.about-main:hover {
    transform: translateY(-7px);
}

.icon {
    width: 50px;
    height: 50px;

    display: flex;
    align-items: center;
    justify-content: center;

    border-radius: 15px;

    background: #f0eaff;

    font-size: 24px;

    margin-bottom: 15px;
}

.about-small p,
.about-main p {
    color: #77718b;

    margin-top: 12px;
}

.about-main h3 {
    font-size: 27px;
}

.about-main h3 span {
    color: #8b5cf6;
}


/* =====================================
   EDUCATION
===================================== */

.education {
    background: #f4f0ff;
}

.education-container {
    max-width: 900px;
    margin: auto;

    display: flex;
    flex-direction: column;

    gap: 20px;
}

.education-card {
    background: white;

    padding: 25px;

    border-radius: 20px;

    display: flex;
    align-items: center;

    gap: 25px;

    box-shadow: 0 8px 25px #ded7eb;

    transition: 0.3s;
}

.education-card:hover {
    transform: translateX(8px);
}

.education-icon {
    min-width: 60px;
    height: 60px;

    display: flex;
    align-items: center;
    justify-content: center;

    background: #f0eaff;

    border-radius: 15px;

    font-size: 27px;
}

.year {
    color: #8b5cf6;

    font-size: 11px;
    font-weight: bold;
}

.education-card h3 {
    margin: 4px 0;
}

.education-card p {
    color: #77718b;
}


/* =====================================
   SKILLS
===================================== */

.skills-container {
    max-width: 1100px;
    margin: auto;

    display: flex;
    flex-wrap: wrap;

    gap: 20px;

    justify-content: center;
}

.skill-card {
    width: 300px;

    background: white;

    padding: 25px;

    border-radius: 20px;

    border: 1px solid #eee8ff;

    box-shadow: 0 8px 25px #ebe5f5;

    transition: 0.3s;
}

.skill-card:hover {
    transform: translateY(-8px);

    border-color: #8b5cf6;
}

.skill-icon {
    font-size: 30px;

    margin-bottom: 10px;
}

.skill-card h3 {
    margin-bottom: 5px;
}

.skill-card p {
    color: #77718b;

    font-size: 14px;
}


/* =====================================
   PROJECTS
===================================== */

.projects {
    background: #f4f0ff;
}

.projects-container {
    max-width: 1100px;
    margin: auto;

    display: flex;
    gap: 25px;

    justify-content: center;

    flex-wrap: wrap;
}

.project-card {
    width: 320px;

    background: white;

    padding: 28px;

    border-radius: 20px;

    box-shadow: 0 8px 25px #ded7eb;

    transition: 0.3s;
}

.project-card:hover {
    transform: translateY(-10px);
}

.project-card.featured {
    border: 2px solid #8b5cf6;
}

.project-number {
    color: #c4b5fd;

    font-size: 28px;
    font-weight: bold;
}

.project-icon {
    font-size: 35px;

    margin: 10px 0;
}

.project-card h3 {
    font-size: 21px;
}

.project-card p {
    color: #77718b;

    margin: 10px 0;
}

.tags {
    display: flex;
    flex-wrap: wrap;

    gap: 6px;

    margin: 15px 0;
}

.tags span {
    background: #f0eaff;

    color: #8b5cf6;

    padding: 5px 9px;

    border-radius: 15px;

    font-size: 10px;
    font-weight: bold;
}

.project-card button {
    border: none;

    background: transparent;

    color: #8b5cf6;

    font-weight: bold;
}


/* =====================================
   CONTACT
===================================== */

.contact-container {
    max-width: 1000px;
    margin: auto;

    display: flex;

    gap: 40px;

    padding: 45px;

    border-radius: 25px;

    background:
        linear-gradient(
            135deg,
            #eee8ff,
            #e0f7ff
        );
}

.contact-info {
    flex: 1;
}

.contact-info h3 {
    font-size: 30px;

    margin-bottom: 15px;
}

.contact-info p {
    color: #77718b;

    margin-bottom: 15px;
}

.contact-info a {
    color: #8b5cf6;

    font-weight: bold;
}

#contactForm {
    flex: 1;

    display: flex;
    flex-direction: column;

    gap: 12px;
}

#contactForm input,
#contactForm textarea {
    padding: 14px;

    border: none;

    border-radius: 10px;

    outline: none;

    font-family: Arial, sans-serif;
}

#contactForm textarea {
    height: 120px;

    resize: none;
}

#contactForm button {
    padding: 13px;

    border: none;

    border-radius: 10px;

    background: #8b5cf6;

    color: white;

    font-weight: bold;
}

#contactForm button:hover {
    background: #7c3aed;
}


/* =====================================
   FOOTER
===================================== */

footer {
    text-align: center;

    background: #211c35;

    color: white;

    padding: 30px;
}

footer h3 {
    font-size: 24px;
}

footer h3 span {
    color: #a78bfa;
}

footer p {
    color: #bbb4ce;

    margin-top: 5px;
}


/* =====================================
   DARK MODE
===================================== */

body.dark {
    background: #11101c;

    color: white;
}

body.dark header {
    background: #181625;

    border-color: #302b40;
}

body.dark .nav-links a {
    color: #d2ccdf;
}

body.dark .home {
    background:
        radial-gradient(
            circle at 80% 20%,
            #342653,
            transparent 30%
        ),
        #11101c;
}

body.dark .home h2 {
    color: #d2ccdf;
}

body.dark .intro {
    color: #aaa3b9;
}

body.dark .about-small,
body.dark .about-main,
body.dark .education-card,
body.dark .skill-card,
body.dark .project-card {
    background: #1c1929;

    border-color: #302b40;

    color: white;
}

body.dark .about-small p,
body.dark .about-main p,
body.dark .education-card p,
body.dark .skill-card p,
body.dark .project-card p {
    color: #aaa3b9;
}

body.dark .education,
body.dark .projects {
    background: #171521;
}

body.dark .photo-container,
body.dark .photo-label {
    background: #1c1929;
}

body.dark #themeButton {
    background: #302b40;
}

body.dark .contact-container {
    background: #241f35;
}


/* =====================================
   RESPONSIVE DESIGN
===================================== */

@media (max-width: 850px) {

    .nav-links {
        gap: 12px;
    }

    .home-content {
        flex-direction: column-reverse;

        text-align: center;
    }

    .intro {
        margin-left: auto;
        margin-right: auto;
    }

    .buttons {
        justify-content: center;
    }

    .about-container {
        flex-direction: column;
    }

    .contact-container {
        flex-direction: column;
    }

}


@media (max-width: 600px) {

    nav {
        flex-wrap: wrap;

        justify-content: center;

        gap: 15px;
    }

    .nav-links {
        order: 3;

        width: 100%;

        justify-content: center;

        flex-wrap: wrap;
    }

    .home {
        padding: 60px 5%;
    }

    .home h1 {
        font-size: 48px;
    }

    .home h2 {
        font-size: 22px;
    }

    .photo-area {
        width: 300px;
        height: 300px;
    }

    .circle-background {
        width: 270px;
        height: 270px;
    }

    .photo-container {
        width: 240px;
        height: 240px;
    }

    .section {
        padding: 70px 5%;
    }

    .heading h2 {
        font-size: 34px;
    }

    .skill-card,
    .project-card {
        width: 100%;
    }

    .contact-container {
        padding: 25px;
    }

}