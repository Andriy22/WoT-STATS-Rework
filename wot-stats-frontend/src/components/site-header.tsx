import { Separator } from "@/components/ui/separator";
import { SidebarTrigger } from "@/components/ui/sidebar";
import { Button } from "@/components/ui/button";
import Link from "next/link";
import {
  IconBrandGithub,
  IconLockSquare,
  IconFileDescription,
} from "@tabler/icons-react";

export function SiteHeader() {
  return (
    <header className="flex h-(--header-height) shrink-0 items-center gap-2 border-b border-border bg-background/95 backdrop-blur transition-[width,height] ease-linear group-has-data-[collapsible=icon]/sidebar-wrapper:h-(--header-height)">
      <div className="flex w-full items-center gap-1 px-4 lg:gap-2 lg:px-6">
        <SidebarTrigger className="-ml-1 text-primary hover:bg-primary/10" />
        <Separator
          orientation="vertical"
          className="mx-2 data-[orientation=vertical]:h-5"
        />
        <div className="flex items-center">
          {/* <Link href="/" className="flex items-center gap-2 hover:opacity-80 transition-opacity">
            <span className="text-lg font-bold text-primary tracking-tight">WOT-STATS</span>
            <span className="text-xs bg-primary/10 text-primary px-1.5 py-0.5 rounded-md font-medium">Remake</span>
          </Link> */}
        </div>

        <div className="ml-auto flex items-center gap-2">
          {/* <nav className="hidden md:flex items-center gap-1">
            <Button
              variant="ghost"
              size="sm"
              asChild
              className="text-muted-foreground hover:text-primary"
            >
              <Link href="/privacy" className="flex items-center gap-1.5">
                <IconLockSquare className="size-4" />
                <span>Privacy</span>
              </Link>
            </Button>
            <Button
              variant="ghost"
              size="sm"
              asChild
              className="text-muted-foreground hover:text-primary"
            >
              <Link href="/eula" className="flex items-center gap-1.5">
                <IconFileDescription className="size-4" />
                <span>EULA</span>
              </Link>
            </Button>
          </nav>

          <Button
            variant="outline"
            size="sm"
            asChild
            className="hidden sm:flex border-primary/20 text-primary hover:bg-primary/10 hover:text-primary"
          >
            <a
              href="https://github.com/Andriy22/WoT-STATS-Rework"
              rel="noopener noreferrer"
              target="_blank"
            >
              <IconBrandGithub className="size-4" />
              <span>GitHub</span>
            </a>
          </Button> */}
        </div>
      </div>
    </header>
  );
}
